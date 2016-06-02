
using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseboatRental
{
    //Form to accept housebout reservation input and display quote
    public partial class MainForm : Form
    {
        //Constants
        const Int16 MAX_POWER = 4;
        const Int16 MAX_PASSENGERS = 6;
        const Int16 INCLUDED_PASSENGERS = 3;
        const Double BASE_PRICE = 299.97;
        const Double ENGINE_UPGRADE = .09;
        const Int16 INCLUDED_HOURS = 22;
        const Int16 TIME_OVERAGE_FEE_PER_HOUR = 12;
        const Double PER_PERSON_EXTRA = .105;
        const Int16 UPSTREAM_FEE_PER_TOWN = 35;
        const Int16 DOWNSTREAM_CREDIT_PER_TOWN = -30;
        const Double SALES_TAX = .0605;
        const Int16 PM_ALERT_TIME = 20;
        const Int16 AM_ALERT_TIME = 6;
        const Int16 MAX_TRIP_LENGTH_HOURS = 14;
        const String WARNING = "Captain License will be\nrequired at the boat pickup";

        private Double runningTotal = 0; //Stores running quote total

        private enum Town
        {
            Andor, Belk, Caldron, Deritt, Elkoss
        };

        public MainForm()
        {
            InitializeComponent();
        }

        //Calls methods to initialize controls when form load event occurs
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            InitCbTowns();
            InitDatePickers();
            InitTimePickers();
            InitCbEngine();
            InitCbPassengers();
        }

        //Initializes town combo boxes
        private void InitCbTowns()
        {
            foreach (var item in Enum.GetValues(typeof(Town)))
            {
                cboArrival.Items.Add(item);
                cboDeparture.Items.Add(item);
            }

            cboDeparture.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDeparture.SelectedIndex = 0;
            cboArrival.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArrival.SelectedIndex = 1;
        }

        //Initializes date pickers
        private void InitDatePickers()
        {
            dtpDepartDate.MinDate = DateTime.Today;
            dtpDepartDate.Value = DateTime.Today;
            dtpArrivalDate.MinDate = DateTime.Today;
            dtpArrivalDate.Value = DateTime.Today;
        }

        //Initializes time pickers
        private void InitTimePickers()
        {
            DateTime now = DateTime.Now;
            int year = now.Year;
            int month = now.Month;
            int day = now.Day;
            int hour = now.Hour;
            DateTime dtInitial = new DateTime(year, month, day, hour + 1, 0, 0);  //rounds time to nearest hour

            //Restricts time changes to whole hours
            dtpDepartTime.CustomFormat = "hh:00 tt"; 
            dtpDepartTime.Format = DateTimePickerFormat.Custom;
            dtpDepartTime.ShowUpDown = true;
            dtpDepartTime.Value = dtInitial;

            dtpArrivalTime.CustomFormat = "hh:00 tt";
            dtpArrivalTime.Format = DateTimePickerFormat.Custom;
            dtpArrivalTime.ShowUpDown = true;
            dtpArrivalTime.Value = dtInitial;
        }

        //Initializes engine level combo box
        private void InitCbEngine()
        {
            for (Int16 i = 1; i <= MAX_POWER; i++)
            {
                cboPower.Items.Add(i);
            }
            cboPower.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPower.SelectedIndex = 0;
        }

        //Initializes number of passengers combo box
        private void InitCbPassengers()
        {
            for (Int16 i = 1; i <= MAX_PASSENGERS; i++)
            {
                cboNumPassengers.Items.Add(i);
            }
            cboNumPassengers.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNumPassengers.SelectedIndex = 0;
        }

        //Button event handler
        private void btnQuote_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            try
            {
                processQuote();
            }
            catch (InvalidDestinationException ex)
            {
                errProvider.SetError(lblError, ex.Message);
            }
            catch (InvalidDateTime ex)
            {
                errProvider.SetError(lblError, ex.Message);
            }
            
        }

        //Processes steps for calculating a quote
        private void processQuote()
        {
            runningTotal = BASE_PRICE; //initializes running total to constant base price 
            Int16 engineLevel = Convert.ToInt16(cboPower.SelectedItem);
            Double engineFee = CalcEngineFee(engineLevel);

            DateTime dDate = dtpDepartDate.Value;
            DateTime aDate = dtpArrivalDate.Value;
            DateTime dTime = dtpDepartTime.Value;
            DateTime aTime = dtpArrivalTime.Value;
            Int32 durationFee = CalcDurationFee(dDate, aDate, dTime, aTime);

            Int16 numPassengers = Convert.ToInt16(cboNumPassengers.SelectedItem);
            Double passengerFee = CalcPassengersFee(numPassengers);

            Int16 arrivalTown = Convert.ToInt16(cboArrival.SelectedItem);
            Int16 departureTown = Convert.ToInt16(cboDeparture.SelectedItem);
            Int32 hopFee = CalcHopFee(arrivalTown, departureTown);

            Double subTotal = runningTotal;
            Double tax = CalcTax();
            Double total = runningTotal;

            DisplayBill(hopFee, durationFee, engineFee, passengerFee, subTotal,
                tax, total);
        }

        //Returns engine fee, updates running total
        private Double CalcEngineFee(Int16 engineLevel)
        {
            Double engineFee = (((engineLevel - 1) * ENGINE_UPGRADE) * runningTotal);
            runningTotal += engineFee;
            return engineFee;
        }

        //Returns duration fee, updates running total
        private Int32 CalcDurationFee(DateTime dDate, DateTime aDate,
            DateTime dTime, DateTime aTime)
        {
            Int32 numExtraHours = 0;
            if (ValidDateTimeInputs(dDate, aDate, dTime, aTime))
            {
                numExtraHours = CalcOverageHours(dDate, aDate, dTime, aTime);
            }
            Int32 durationFee = numExtraHours * TIME_OVERAGE_FEE_PER_HOUR;
            runningTotal += durationFee;
            return durationFee;
        }

        //Checks for valid date and time inputs.  Throws InvalidDateTime exception if inputs not valid
        private Boolean ValidDateTimeInputs(DateTime dDate, DateTime aDate,
            DateTime dTime, DateTime aTime)
        {
            int dateCompare = aDate.CompareTo(dDate);
            int timeCompare = aTime.CompareTo(dTime);

            if (dateCompare < 0)
            {
                throw new InvalidDateTime("Arrival date can't be earlier than Departure date");
            }
            else if (dateCompare == 0 && timeCompare < 0)
            {
                throw new InvalidDateTime("Arrival time can't be earlier than Departure time");
            }
            else if (dTime.CompareTo(DateTime.Now) < 0 && dDate.Equals(DateTime.Today))
            {
                throw new InvalidDateTime("Departure time must be later than current date and time");
            }
            else
            {
                TimeSpan tripLength = aDate - dDate;
                if (tripLength.Days > MAX_TRIP_LENGTH_HOURS)
                {
                    throw new InvalidDateTime("Contact office to arrange trips longer than 14 days");
                }
                return true;
            }
        }

        //Returns number of excess hours beyond included hours, otherwise returns 0
        private Int32 CalcOverageHours(DateTime dDate, DateTime aDate,
            DateTime dTime, DateTime aTime)
        {
            double hours = (aDate - dDate).TotalHours;  //number of hours between date selections
            hours += (aTime - dTime).TotalHours; //number of hours between time selections
            if (hours <= INCLUDED_HOURS)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(hours - INCLUDED_HOURS);
            }
        }

        //Returns excess passenger fee, if any, otherwise returns 0.  Updates running total
        private Double CalcPassengersFee(Int16 numPassengers)
        {
            if (numPassengers <= INCLUDED_PASSENGERS)
            {
                return 0;
            }
            else
            {
                Int32 numPassengersOver = numPassengers - INCLUDED_PASSENGERS;
                double passengerFee = (numPassengersOver * PER_PERSON_EXTRA) * runningTotal;
                runningTotal += passengerFee;
                return passengerFee;
            }
        }

        /*Returns upstream/downstream fee/credit.  Updates running total.  Throws exception if arrival and 
        departure towns are equal*/
        private Int32 CalcHopFee(Int16 arrivalTown, Int16 departureTown)
        {
            Int32 hopFee = 0;
            Int32 numHops = arrivalTown - departureTown;
            if (numHops == 0)
            {
                throw new InvalidDestinationException();
            }
            else if (numHops > 0)
            {
                hopFee = numHops * DOWNSTREAM_CREDIT_PER_TOWN;
            }
            else
            {
                hopFee = Math.Abs(numHops) * UPSTREAM_FEE_PER_TOWN;
            }
            runningTotal += hopFee;
            return hopFee;
        }

        //Returns sales tax, updates running total
        private Double CalcTax()
        {
            Double tax = runningTotal * SALES_TAX;
            runningTotal += tax;
            return tax;
        }

        //Displays itemized quote in appropriate label
        private void DisplayBill(Int32 hopFee, Int32 durationFee, Double engineFee,
           Double passengerFee, Double subTotal, Double tax, Double total)
        {
            lblBase.Text = BASE_PRICE.ToString("c");
            lblHop.Text = hopFee.ToString("c");
            lblTime.Text = durationFee.ToString("c");
            lblEngine.Text = engineFee.ToString("c");
            lblPassengers.Text = passengerFee.ToString("c");
            lblSub.Text = subTotal.ToString("c");
            lblTax.Text = tax.ToString("c");
            lblTotal.Text = total.ToString("c");
        }

        /*
        Event handlers for control changed events
        */
        private void dtpDepartTime_ValueChanged(object sender, EventArgs e)
        {
            SpecialLicense();
        }

        private void dtpArrivalTime_ValueChanged(object sender, EventArgs e)
        {
            SpecialLicense();
        }

        private void cboPower_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecialLicense();
        }

        /*
        Gets values of engine level and date/time picker comboboxes.  If values are outside normal
        range, display warning.  Otherwise, set warning to empty string
        */
        private void SpecialLicense()
        {
            Int16 engineLevel = Convert.ToInt16(cboPower.SelectedItem);

            DateTime dTime = dtpDepartTime.Value;
            int dHour = dTime.Hour;
            DateTime aTime = dtpArrivalTime.Value;
            int aHour = aTime.Hour;

            if (engineLevel == MAX_POWER || dHour <= AM_ALERT_TIME || dHour >= PM_ALERT_TIME ||
                aHour <= AM_ALERT_TIME || aHour >= PM_ALERT_TIME)
            {
                lblCaptain.Text = WARNING;
            }
            else
            {
                lblCaptain.Text = "";
            }
        }
    }
}
