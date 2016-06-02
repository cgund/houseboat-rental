namespace HouseboatRental
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOuter = new System.Windows.Forms.GroupBox();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.grpArrival = new System.Windows.Forms.GroupBox();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboArrival = new System.Windows.Forms.ComboBox();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.grpDepart = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDepartTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cboDeparture = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDepartDate = new System.Windows.Forms.DateTimePicker();
            this.cboPower = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNumPassengers = new System.Windows.Forms.ComboBox();
            this.btnQuote = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblHop = new System.Windows.Forms.Label();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.grpOuter.SuspendLayout();
            this.grpArrival.SuspendLayout();
            this.grpDepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "River Rentals";
            // 
            // grpOuter
            // 
            this.grpOuter.Controls.Add(this.lblCaptain);
            this.grpOuter.Controls.Add(this.lblError);
            this.grpOuter.Controls.Add(this.grpArrival);
            this.grpOuter.Controls.Add(this.grpDepart);
            this.grpOuter.Controls.Add(this.cboPower);
            this.grpOuter.Controls.Add(this.label7);
            this.grpOuter.Controls.Add(this.label6);
            this.grpOuter.Controls.Add(this.cboNumPassengers);
            this.grpOuter.Location = new System.Drawing.Point(32, 47);
            this.grpOuter.Name = "grpOuter";
            this.grpOuter.Size = new System.Drawing.Size(544, 246);
            this.grpOuter.TabIndex = 1;
            this.grpOuter.TabStop = false;
            this.grpOuter.Text = "Trip Information";
            // 
            // lblCaptain
            // 
            this.lblCaptain.AutoSize = true;
            this.lblCaptain.ForeColor = System.Drawing.Color.Red;
            this.lblCaptain.Location = new System.Drawing.Point(369, 176);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(0, 13);
            this.lblCaptain.TabIndex = 14;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(266, 77);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(28, 13);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "error";
            // 
            // grpArrival
            // 
            this.grpArrival.Controls.Add(this.dtpArrivalTime);
            this.grpArrival.Controls.Add(this.label12);
            this.grpArrival.Controls.Add(this.label4);
            this.grpArrival.Controls.Add(this.label3);
            this.grpArrival.Controls.Add(this.cboArrival);
            this.grpArrival.Controls.Add(this.dtpArrivalDate);
            this.grpArrival.Location = new System.Drawing.Point(26, 93);
            this.grpArrival.Name = "grpArrival";
            this.grpArrival.Size = new System.Drawing.Size(508, 44);
            this.grpArrival.TabIndex = 6;
            this.grpArrival.TabStop = false;
            this.grpArrival.Text = "Arrival";
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpArrivalTime.Location = new System.Drawing.Point(404, 16);
            this.dtpArrivalTime.MinDate = new System.DateTime(2016, 4, 14, 0, 0, 0, 0);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.Size = new System.Drawing.Size(84, 20);
            this.dtpArrivalTime.TabIndex = 15;
            this.dtpArrivalTime.ValueChanged += new System.EventHandler(this.dtpArrivalTime_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(355, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Town: ";
            // 
            // cboArrival
            // 
            this.cboArrival.FormattingEnabled = true;
            this.cboArrival.Location = new System.Drawing.Point(68, 15);
            this.cboArrival.Name = "cboArrival";
            this.cboArrival.Size = new System.Drawing.Size(121, 21);
            this.cboArrival.TabIndex = 5;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpArrivalDate.Location = new System.Drawing.Point(243, 15);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(89, 20);
            this.dtpArrivalDate.TabIndex = 7;
            // 
            // grpDepart
            // 
            this.grpDepart.Controls.Add(this.label5);
            this.grpDepart.Controls.Add(this.dtpDepartTime);
            this.grpDepart.Controls.Add(this.label11);
            this.grpDepart.Controls.Add(this.cboDeparture);
            this.grpDepart.Controls.Add(this.label2);
            this.grpDepart.Controls.Add(this.dtpDepartDate);
            this.grpDepart.Location = new System.Drawing.Point(26, 25);
            this.grpDepart.Name = "grpDepart";
            this.grpDepart.Size = new System.Drawing.Size(508, 49);
            this.grpDepart.TabIndex = 13;
            this.grpDepart.TabStop = false;
            this.grpDepart.Text = "Departure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Time:";
            // 
            // dtpDepartTime
            // 
            this.dtpDepartTime.Location = new System.Drawing.Point(404, 17);
            this.dtpDepartTime.MinDate = new System.DateTime(2016, 4, 14, 0, 0, 0, 0);
            this.dtpDepartTime.Name = "dtpDepartTime";
            this.dtpDepartTime.Size = new System.Drawing.Size(84, 20);
            this.dtpDepartTime.TabIndex = 13;
            this.dtpDepartTime.ValueChanged += new System.EventHandler(this.dtpDepartTime_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Date:";
            // 
            // cboDeparture
            // 
            this.cboDeparture.FormattingEnabled = true;
            this.cboDeparture.Location = new System.Drawing.Point(68, 17);
            this.cboDeparture.Name = "cboDeparture";
            this.cboDeparture.Size = new System.Drawing.Size(121, 21);
            this.cboDeparture.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Town: ";
            // 
            // dtpDepartDate
            // 
            this.dtpDepartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartDate.Location = new System.Drawing.Point(243, 17);
            this.dtpDepartDate.MinDate = new System.DateTime(2016, 4, 14, 0, 0, 0, 0);
            this.dtpDepartDate.Name = "dtpDepartDate";
            this.dtpDepartDate.Size = new System.Drawing.Size(89, 20);
            this.dtpDepartDate.TabIndex = 3;
            // 
            // cboPower
            // 
            this.cboPower.FormattingEnabled = true;
            this.cboPower.Location = new System.Drawing.Point(255, 201);
            this.cboPower.Name = "cboPower";
            this.cboPower.Size = new System.Drawing.Size(77, 21);
            this.cboPower.TabIndex = 11;
            this.cboPower.SelectedIndexChanged += new System.EventHandler(this.cboPower_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Engine Power Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number of Passengers:";
            // 
            // cboNumPassengers
            // 
            this.cboNumPassengers.FormattingEnabled = true;
            this.cboNumPassengers.Location = new System.Drawing.Point(255, 154);
            this.cboNumPassengers.Name = "cboNumPassengers";
            this.cboNumPassengers.Size = new System.Drawing.Size(77, 21);
            this.cboNumPassengers.TabIndex = 9;
            // 
            // btnQuote
            // 
            this.btnQuote.Location = new System.Drawing.Point(287, 313);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(75, 23);
            this.btnQuote.TabIndex = 2;
            this.btnQuote.Text = "Get Quote";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(596, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itemized Quote";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99087F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.00913F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTax, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSub, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblHop, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengers, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBase, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEngine, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 207);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(130, 183);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 15;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(130, 157);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(0, 13);
            this.lblTax.TabIndex = 14;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(130, 131);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(0, 13);
            this.lblSub.TabIndex = 13;
            // 
            // lblHop
            // 
            this.lblHop.AutoSize = true;
            this.lblHop.Location = new System.Drawing.Point(130, 105);
            this.lblHop.Name = "lblHop";
            this.lblHop.Size = new System.Drawing.Size(0, 13);
            this.lblHop.TabIndex = 12;
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Location = new System.Drawing.Point(130, 79);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(0, 13);
            this.lblPassengers.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Docks Fee:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Extra Passengers Fee:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Extra Time Fee:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Engine Fee:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Base Price:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Tax:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Subtotal:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(130, 1);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(0, 13);
            this.lblBase.TabIndex = 8;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(130, 27);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(0, 13);
            this.lblEngine.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(130, 53);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuote);
            this.Controls.Add(this.grpOuter);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Houseboat Rental Reservations";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpOuter.ResumeLayout(false);
            this.grpOuter.PerformLayout();
            this.grpArrival.ResumeLayout(false);
            this.grpArrival.PerformLayout();
            this.grpDepart.ResumeLayout(false);
            this.grpDepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOuter;
        private System.Windows.Forms.ComboBox cboPower;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNumPassengers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.ComboBox cboArrival;
        private System.Windows.Forms.DateTimePicker dtpDepartDate;
        private System.Windows.Forms.ComboBox cboDeparture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpArrival;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDepart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDepartTime;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblHop;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCaptain;
    }
}

