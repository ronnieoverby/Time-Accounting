using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaywardMachineShopTimeSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbDivisionDepartment.Text == "")
            {
                MessageBox.Show("You must select a department and division.");  //Need to expand on the qualifiers that enable the user to start logging information
                tbEmployeeID.Clear();
            }

            if (tbEmployeeID.Text == "")
            {
                MessageBox.Show("You must enter your employee ID code.");
                cbDivisionDepartment.Text = "";
            }

            if (tbEmployeeID.Text == "34475" && cbDivisionDepartment.Text != "")
            {
                tbEmployeeName.Text = "Dustin Shane Overby";
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string workOrder = tbWorkOrder.Text;
            string partNumber = tbPart.Text;
            string machineNumber = cbMachine.Text;
            string operationNumber = tbOperation.Text;
            string codeStatus = cbCode.Text;
            string standardPPH = tbStandardPPH.Text;
            string actualPPH = tbActualPPH.Text;
            string quantity = tbQuantity.Text;
            string scrap = tbScrap.Text;
            string standardSUH = tbStandardSetupHrs.Text;
            string actualSUH = tbActualSetupHrs.Text;
            double totalHours = 0;
            
            if (workOrder == "")
            {
                workOrder = "N/A";
            }

            if (partNumber == "")
            {
                partNumber = "N/A";
            }

            if (machineNumber == "")
            {
                machineNumber = "N/A";
            }

            if (operationNumber == "")
            {
                operationNumber = "N/A";
            }

            if (codeStatus == "")
            {
                codeStatus = "N/A";
            }

            if (standardPPH == "")
            {
                standardPPH = "N/A";
            }

            if (quantity == "")
            {
                quantity = "N/A";
            }

            if (scrap == "")
            {
                scrap = "N/A";
            }

            if (standardSUH == "")
            {
                standardSUH = "N/A";
            }

            if (lblRow1.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";
                    
                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours1.Text = totalHoursSet.ToString();
                }

                
                if(actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency1.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours1.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs1.Text = "N/A";
                 }
                else                                                  
                 {                                                    
                    totalHours = double.Parse(actualSUH);             
                    double actualSUHSet = double.Parse(actualSUH);    
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency1.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours1.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs1.Text = actualSUH;
                 }

                 lblRow1.Text = "1.)";
                 lblWorkOrder1.Text = workOrder;
                 lblPart1.Text = partNumber;
                 lblMachine1.Text = machineNumber;
                 lblOperation1.Text = operationNumber;
                 lblCode1.Text = codeStatus;
                 lblStandardPPH1.Text = standardPPH.ToString();
                 lblActualPPH1.Text = actualPPH.ToString();
                 lblQuantity1.Text = quantity.ToString();
                 lblScrap1.Text = scrap.ToString();
                 lblStandardSUHrs1.Text = standardSUH.ToString();
            }

            else if(lblRow2.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours2.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency2.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours2.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs2.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency2.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours2.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs2.Text = actualSUH;
                }

                lblRow2.Text = "2.)";
                lblWorkOrder2.Text = workOrder;
                lblPart2.Text = partNumber;
                lblMachine2.Text = machineNumber;
                lblOperation2.Text = operationNumber;
                lblCode2.Text = codeStatus;
                lblStandardPPH2.Text = standardPPH.ToString();
                lblActualPPH2.Text = actualPPH.ToString();
                lblQuantity2.Text = quantity.ToString();
                lblScrap2.Text = scrap.ToString();
                lblStandardSUHrs2.Text = standardSUH.ToString();
            }

            else if(lblRow3.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours3.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency3.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours3.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs3.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency3.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours3.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs3.Text = actualSUH;
                }

                lblRow3.Text = "3.)";
                lblWorkOrder3.Text = workOrder;
                lblPart3.Text = partNumber;
                lblMachine3.Text = machineNumber;
                lblOperation3.Text = operationNumber;
                lblCode3.Text = codeStatus;
                lblStandardPPH3.Text = standardPPH.ToString();
                lblActualPPH3.Text = actualPPH.ToString();
                lblQuantity3.Text = quantity.ToString();
                lblScrap3.Text = scrap.ToString();
                lblStandardSUHrs3.Text = standardSUH.ToString();
            }

            else if (lblRow4.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours4.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency4.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours4.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs4.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency4.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours4.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs4.Text = actualSUH;
                }

                lblRow4.Text = "4.)";
                lblWorkOrder4.Text = workOrder;
                lblPart4.Text = partNumber;
                lblMachine4.Text = machineNumber;
                lblOperation4.Text = operationNumber;
                lblCode4.Text = codeStatus;
                lblStandardPPH4.Text = standardPPH.ToString();
                lblActualPPH4.Text = actualPPH.ToString();
                lblQuantity4.Text = quantity.ToString();
                lblScrap4.Text = scrap.ToString();
                lblStandardSUHrs4.Text = standardSUH.ToString();
            }

            else if (lblRow5.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours5.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency5.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours5.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs5.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency5.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours5.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs5.Text = actualSUH;
                }

                lblRow5.Text = "5.)";
                lblWorkOrder5.Text = workOrder;
                lblPart5.Text = partNumber;
                lblMachine5.Text = machineNumber;
                lblOperation5.Text = operationNumber;
                lblCode5.Text = codeStatus;
                lblStandardPPH5.Text = standardPPH.ToString();
                lblActualPPH5.Text = actualPPH.ToString();
                lblQuantity5.Text = quantity.ToString();
                lblScrap5.Text = scrap.ToString();
                lblStandardSUHrs5.Text = standardSUH.ToString();
            }

            else if (lblRow6.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours6.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency6.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours6.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs6.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency6.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours6.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs6.Text = actualSUH;
                }

                lblRow6.Text = "6.)";
                lblWorkOrder6.Text = workOrder;
                lblPart6.Text = partNumber;
                lblMachine6.Text = machineNumber;
                lblOperation6.Text = operationNumber;
                lblCode6.Text = codeStatus;
                lblStandardPPH6.Text = standardPPH.ToString();
                lblActualPPH6.Text = actualPPH.ToString();
                lblQuantity6.Text = quantity.ToString();
                lblScrap6.Text = scrap.ToString();
                lblStandardSUHrs6.Text = standardSUH.ToString();
            }

            else if (lblRow7.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours7.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency7.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours7.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs7.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency7.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours7.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs7.Text = actualSUH;
                }

                lblRow7.Text = "7.)";
                lblWorkOrder7.Text = workOrder;
                lblPart7.Text = partNumber;
                lblMachine7.Text = machineNumber;
                lblOperation7.Text = operationNumber;
                lblCode7.Text = codeStatus;
                lblStandardPPH7.Text = standardPPH.ToString();
                lblActualPPH7.Text = actualPPH.ToString();
                lblQuantity7.Text = quantity.ToString();
                lblScrap7.Text = scrap.ToString();
                lblStandardSUHrs7.Text = standardSUH.ToString();
            }

            else if (lblRow8.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours8.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency8.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours8.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs8.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency8.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours8.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs8.Text = actualSUH;
                }

                lblRow8.Text = "8.)";
                lblWorkOrder8.Text = workOrder;
                lblPart8.Text = partNumber;
                lblMachine8.Text = machineNumber;
                lblOperation8.Text = operationNumber;
                lblCode8.Text = codeStatus;
                lblStandardPPH8.Text = standardPPH.ToString();
                lblActualPPH8.Text = actualPPH.ToString();
                lblQuantity8.Text = quantity.ToString();
                lblScrap8.Text = scrap.ToString();
                lblStandardSUHrs8.Text = standardSUH.ToString();
            }

            else if (lblRow9.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours9.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency9.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours9.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs9.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency9.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours9.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs9.Text = actualSUH;
                }

                lblRow9.Text = "9.)";
                lblWorkOrder9.Text = workOrder;
                lblPart9.Text = partNumber;
                lblMachine9.Text = machineNumber;
                lblOperation9.Text = operationNumber;
                lblCode9.Text = codeStatus;
                lblStandardPPH9.Text = standardPPH.ToString();
                lblActualPPH9.Text = actualPPH.ToString();
                lblQuantity9.Text = quantity.ToString();
                lblScrap9.Text = scrap.ToString();
                lblStandardSUHrs9.Text = standardSUH.ToString();
            }

            else if (lblRow10.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours10.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency10.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours10.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs10.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency10.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours10.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs10.Text = actualSUH;
                }

                lblRow10.Text = "10.)";
                lblWorkOrder10.Text = workOrder;
                lblPart10.Text = partNumber;
                lblMachine10.Text = machineNumber;
                lblOperation10.Text = operationNumber;
                lblCode10.Text = codeStatus;
                lblStandardPPH10.Text = standardPPH.ToString();
                lblActualPPH10.Text = actualPPH.ToString();
                lblQuantity10.Text = quantity.ToString();
                lblScrap10.Text = scrap.ToString();
                lblStandardSUHrs10.Text = standardSUH.ToString();
            }

            else if (lblRow11.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours11.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency11.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours11.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs11.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency11.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours11.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs11.Text = actualSUH;
                }

                lblRow11.Text = "11.)";
                lblWorkOrder11.Text = workOrder;
                lblPart11.Text = partNumber;
                lblMachine11.Text = machineNumber;
                lblOperation11.Text = operationNumber;
                lblCode11.Text = codeStatus;
                lblStandardPPH11.Text = standardPPH.ToString();
                lblActualPPH11.Text = actualPPH.ToString();
                lblQuantity11.Text = quantity.ToString();
                lblScrap11.Text = scrap.ToString();
                lblStandardSUHrs11.Text = standardSUH.ToString();
            }

            else if (lblRow12.Text == "")
            {
                if (actualPPH == "")
                {
                    totalHours = double.Parse(actualSUH);
                    actualPPH = "N/A";

                }
                else
                {
                    double quantitySet = double.Parse(quantity);
                    double actualPPHSet = double.Parse(actualPPH);
                    double totalHoursSet = 0;
                    totalHoursSet = quantitySet / actualPPHSet;
                    lblTotalHours12.Text = totalHoursSet.ToString();
                }


                if (actualSUH == "")
                {
                    totalHours = double.Parse(quantity) / double.Parse(actualPPH);
                    int standardPPHSet = int.Parse(standardPPH);
                    double totalHoursSet = totalHours;
                    double efficiencyTest1 = 0;
                    double efficiencyTest2 = 0;
                    double efficiencyTest3 = 0;
                    int quantitySet = int.Parse(quantity);
                    efficiencyTest1 = standardPPHSet * totalHoursSet;
                    efficiencyTest2 = quantitySet * 100;
                    efficiencyTest3 = efficiencyTest2 / efficiencyTest1;
                    lblEfficiency12.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours12.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs12.Text = "N/A";
                }
                else
                {
                    totalHours = double.Parse(actualSUH);
                    double actualSUHSet = double.Parse(actualSUH);
                    double standardSUHSet = double.Parse(standardSUH);
                    double efficiencyTest3 = 0;
                    double negEfficiency1 = actualSUHSet / standardSUHSet;
                    double negEfficiency2 = 1 / negEfficiency1;
                    efficiencyTest3 = negEfficiency2 * 100;
                    lblEfficiency12.Text = Math.Round(efficiencyTest3, 2).ToString() + "%";
                    lblTotalHours12.Text = Math.Round(totalHours, 2).ToString();
                    lblActualSUHrs12.Text = actualSUH;
                }

                lblRow12.Text = "12.)";
                lblWorkOrder12.Text = workOrder;
                lblPart12.Text = partNumber;
                lblMachine12.Text = machineNumber;
                lblOperation12.Text = operationNumber;
                lblCode12.Text = codeStatus;
                lblStandardPPH12.Text = standardPPH.ToString();
                lblActualPPH12.Text = actualPPH.ToString();
                lblQuantity12.Text = quantity.ToString();
                lblScrap12.Text = scrap.ToString();
                lblStandardSUHrs12.Text = standardSUH.ToString();
            }

            tbWorkOrder.Clear();
            tbPart.Clear();
            cbMachine.ResetText();
            tbOperation.Clear();
            cbCode.ResetText();
            tbStandardPPH.Clear();
            tbActualPPH.Clear();
            tbQuantity.Clear();
            tbScrap.Clear();
            tbStandardSetupHrs.Clear();
            tbActualSetupHrs.Clear();
        }
    }
}
