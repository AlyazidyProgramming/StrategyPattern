using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StrategyPattern_DiscountSaleExample
{
    public class frmStrategy : Form
    {
        private CheckBox chkStudentDiscount;
        private CheckBox chkLayaltyStudentDiscount;
        private CheckBox chkLayalDiscount;
        private CheckBox chkCustmoerDiscount;
        private Button btnNetSale;
        private NumericUpDown numricSale;
        private Label lblNetSale;
        private Label lblCurrentStrategy;
        private CheckBox chkfirstTimeCustomerVister;
        private void InitializeComponent()
        {
            this.chkStudentDiscount = new System.Windows.Forms.CheckBox();
            this.chkLayaltyStudentDiscount = new System.Windows.Forms.CheckBox();
            this.chkLayalDiscount = new System.Windows.Forms.CheckBox();
            this.chkCustmoerDiscount = new System.Windows.Forms.CheckBox();
            this.chkfirstTimeCustomerVister = new System.Windows.Forms.CheckBox();
            this.btnNetSale = new System.Windows.Forms.Button();
            this.numricSale = new System.Windows.Forms.NumericUpDown();
            this.lblNetSale = new System.Windows.Forms.Label();
            this.lblCurrentStrategy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numricSale)).BeginInit();
            this.SuspendLayout();
            // 
            // chkStudentDiscount
            // 
            this.chkStudentDiscount.AutoSize = true;
            this.chkStudentDiscount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkStudentDiscount.Location = new System.Drawing.Point(12, 13);
            this.chkStudentDiscount.Name = "chkStudentDiscount";
            this.chkStudentDiscount.Size = new System.Drawing.Size(102, 23);
            this.chkStudentDiscount.TabIndex = 0;
            this.chkStudentDiscount.Text = "checkBox1";
            this.chkStudentDiscount.UseVisualStyleBackColor = true;
            this.chkStudentDiscount.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkLayaltyStudentDiscount
            // 
            this.chkLayaltyStudentDiscount.AutoSize = true;
            this.chkLayaltyStudentDiscount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkLayaltyStudentDiscount.Location = new System.Drawing.Point(12, 52);
            this.chkLayaltyStudentDiscount.Name = "chkLayaltyStudentDiscount";
            this.chkLayaltyStudentDiscount.Size = new System.Drawing.Size(102, 23);
            this.chkLayaltyStudentDiscount.TabIndex = 0;
            this.chkLayaltyStudentDiscount.Text = "checkBox1";
            this.chkLayaltyStudentDiscount.UseVisualStyleBackColor = true;
            this.chkLayaltyStudentDiscount.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkLayalDiscount
            // 
            this.chkLayalDiscount.AutoSize = true;
            this.chkLayalDiscount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkLayalDiscount.Location = new System.Drawing.Point(12, 96);
            this.chkLayalDiscount.Name = "chkLayalDiscount";
            this.chkLayalDiscount.Size = new System.Drawing.Size(102, 23);
            this.chkLayalDiscount.TabIndex = 0;
            this.chkLayalDiscount.Text = "checkBox1";
            this.chkLayalDiscount.UseVisualStyleBackColor = true;
            this.chkLayalDiscount.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkCustmoerDiscount
            // 
            this.chkCustmoerDiscount.AutoSize = true;
            this.chkCustmoerDiscount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkCustmoerDiscount.Location = new System.Drawing.Point(12, 141);
            this.chkCustmoerDiscount.Name = "chkCustmoerDiscount";
            this.chkCustmoerDiscount.Size = new System.Drawing.Size(102, 23);
            this.chkCustmoerDiscount.TabIndex = 0;
            this.chkCustmoerDiscount.Text = "checkBox1";
            this.chkCustmoerDiscount.UseVisualStyleBackColor = true;
            this.chkCustmoerDiscount.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox5
            // 
            this.chkfirstTimeCustomerVister.AutoSize = true;
            this.chkfirstTimeCustomerVister.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkfirstTimeCustomerVister.Location = new System.Drawing.Point(12, 184);
            this.chkfirstTimeCustomerVister.Name = "checkBox5";
            this.chkfirstTimeCustomerVister.Size = new System.Drawing.Size(102, 23);
            this.chkfirstTimeCustomerVister.TabIndex = 0;
            this.chkfirstTimeCustomerVister.Text = "checkBox1";
            this.chkfirstTimeCustomerVister.UseVisualStyleBackColor = true;
            this.chkfirstTimeCustomerVister.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // btnNetSale
            // 
            this.btnNetSale.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNetSale.Location = new System.Drawing.Point(195, 151);
            this.btnNetSale.Name = "btnNetSale";
            this.btnNetSale.Size = new System.Drawing.Size(106, 36);
            this.btnNetSale.TabIndex = 1;
            this.btnNetSale.Text = "Net Sale";
            this.btnNetSale.UseVisualStyleBackColor = true;
            this.btnNetSale.Click += new System.EventHandler(this.btnNetSale_Click);
            // 
            // numricSale
            // 
            this.numricSale.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numricSale.Location = new System.Drawing.Point(195, 111);
            this.numricSale.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numricSale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numricSale.Name = "numricSale";
            this.numricSale.Size = new System.Drawing.Size(106, 27);
            this.numricSale.TabIndex = 2;
            this.numricSale.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // lblNetSale
            // 
            this.lblNetSale.AutoSize = true;
            this.lblNetSale.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblNetSale.ForeColor = System.Drawing.Color.Red;
            this.lblNetSale.Location = new System.Drawing.Point(210, 64);
            this.lblNetSale.Name = "lblNetSale";
            this.lblNetSale.Size = new System.Drawing.Size(75, 23);
            this.lblNetSale.TabIndex = 3;
            this.lblNetSale.Text = "net sale";
            // 
            // lblCurrentStrategy
            // 
            this.lblCurrentStrategy.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblCurrentStrategy.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentStrategy.Location = new System.Drawing.Point(12, 234);
            this.lblCurrentStrategy.Name = "lblCurrentStrategy";
            this.lblCurrentStrategy.Size = new System.Drawing.Size(446, 124);
            this.lblCurrentStrategy.TabIndex = 3;
            this.lblCurrentStrategy.Text = "_";
            // 
            // frmStrategy
            // 
            this.ClientSize = new System.Drawing.Size(464, 363);
            this.Controls.Add(this.lblCurrentStrategy);
            this.Controls.Add(this.lblNetSale);
            this.Controls.Add(this.numricSale);
            this.Controls.Add(this.btnNetSale);
            this.Controls.Add(this.chkfirstTimeCustomerVister);
            this.Controls.Add(this.chkCustmoerDiscount);
            this.Controls.Add(this.chkLayalDiscount);
            this.Controls.Add(this.chkLayaltyStudentDiscount);
            this.Controls.Add(this.chkStudentDiscount);
            this.Name = "frmStrategy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numricSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //save current discount startegy
        private StrategyDiscountBase _currentStrategyDiscount = null;

        //using list for allow to mix discount strategy
        List<StrategyDiscountBase> _currentStrategyDiscountList = null;

        public frmStrategy()
        {
            InitializeComponent();
            _setNamesComponent();
            _initializeDiscountStrategies();
            _currentStrategyDiscountList = new List<StrategyDiscountBase>();
        }
        private void _setNamesComponent()
        {
            chkCustmoerDiscount.Text = "CustomerDiscount";
            chkStudentDiscount.Text = "StudentDiscount";
            chkLayalDiscount.Text = "LayaltyDiscount";
            chkLayaltyStudentDiscount.Text = "LayaltyStudentDiscount";
            chkfirstTimeCustomerVister.Text = "chkfirstTimeCustomerVister";
        }
        private void _initializeDiscountStrategies()
        {
            //dont using tag in real program because you must make boxing and unboxing --> 
            //when you want to access object.
            //for best practices using custom control.
            chkCustmoerDiscount.Tag = new CustomerDiscount();
            chkStudentDiscount.Tag = new StudentDiscount();
            chkLayalDiscount.Tag = new LayaltyDiscount();
            chkLayaltyStudentDiscount.Tag = new LayaltyStudentDiscount();
            chkfirstTimeCustomerVister.Tag = new FirstTimeCustomerVisiterDiscount();
        }
        private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
        {
            // 
            CheckBox chk = (CheckBox)sender;

            StrategyDiscountBase currentdiscount = chk.Tag as StrategyDiscountBase;


            if (chk.Checked)
                _currentStrategyDiscountList.Add(currentdiscount);
            else
                _currentStrategyDiscountList.Remove(currentdiscount);


        }
        private void btnNetSale_Click(object sender, System.EventArgs e)
        {


            bool isSelectDiscountStrategy = _currentStrategyDiscountList.Count > 0;

            if (isSelectDiscountStrategy)
            {
                bool isMixStrategy = _currentStrategyDiscountList.Count > 1;

                if (isMixStrategy)
                    _currentStrategyDiscount = new MixDiscount(_currentStrategyDiscountList);
                else
                    _currentStrategyDiscount = _currentStrategyDiscountList[0];
            }
            else
            {
                _currentStrategyDiscount = new NonDiscount();
            }


            decimal netSale = _currentStrategyDiscount.ApplayDiscount(numricSale.Value);

            lblNetSale.Text = netSale.ToString("C2",
                            System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            lblCurrentStrategy.Text =
                _currentStrategyDiscountList.Count > 0
                ?
                string.Join("",
                _currentStrategyDiscountList.Select(x => x.GetObjFormattingTesting()))
                :
                _currentStrategyDiscount.GetObjFormattingTesting();

        }

    }
}
