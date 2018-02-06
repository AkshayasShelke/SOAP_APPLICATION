using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avalara.AvaTax.Adapter;
using Avalara.AvaTax.Adapter.TaxService;
using log4net;
using System.IO;
using System.Xml.Serialization;

namespace SOAP_Application
{
    public partial class TransactionForm : Form
    {

        public static GetTaxRequest getTaxRequest = new GetTaxRequest();
        public TaxSvc _taxService;
        public GetTaxResult getTaxResult;
        public DocumentType docType;
        public bool statusCmp, statusLine, statusAdd;
        public Line[] lno = new Line[15000];
        DataTable table = new DataTable();
        public int selectedRow;
        public bool ReturnValue_Company, ReturnValue_Line, ReturnValue_Address;
        public string ProdlineNo, CompCode, DocCode, date, Dtype, Quantity, Amount;
        public string CustCode, SfLine, SfState, SfCity, SfZip, StLine, StState, StCity, StZip;
        public TransactionForm()
        {
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("LineNo", typeof(string));
            table.Columns.Add("Quantity", typeof(string));
            table.Columns.Add("Amount", typeof(string));
            DgvLine.DataSource = table;

        }

        private void butLoadResult_Click(object sender, EventArgs e)
        {
            getTaxRequest.Lines.Clear();
            ReturnValue_Line = SetLineDetails();
  
            getTaxResult = _taxService.GetTax(getTaxRequest);
            bool FinalResultValue;
            if (ReturnValue_Company == false || ReturnValue_Line == false || ReturnValue_Address == false)
            {
                FinalResultValue = false;
            }
            else
            {
                txtResultCode.Text = Convert.ToString(getTaxResult.ResultCode);
                txtResultDocCode.Text = getTaxResult.DocCode;
                txtResultDocDate.Text = Convert.ToString(getTaxResult.DocDate);
                txtResultTotTaxable.Text = Convert.ToString(getTaxResult.TotalTaxable);
                txtResultTotAmt.Text = Convert.ToString(getTaxResult.TotalAmount);
                txtTotalTax.Text = Convert.ToString(getTaxResult.TotalTax);
                txtResultTotDisc.Text = Convert.ToString(getTaxResult.TotalDiscount);
                txtResultTransId.Text = getTaxResult.TransactionId;
                FinalResultValue = true;
            }
            if (FinalResultValue == false)
            {
                MessageBox.Show(getTaxResult.Messages[0].Summary.ToString());
            }

        }

        private void butUpdateLine_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = DgvLine.Rows[selectedRow];
            newRow.Cells[0].Value = txtLineNo.Text;
            newRow.Cells[1].Value = txtQuant.Text;
            newRow.Cells[2].Value = txtAmt.Text;
        }


        private void DgvLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow newRow = DgvLine.Rows[selectedRow];
            txtLineNo.Text = newRow.Cells[0].Value.ToString();
            txtQuant.Text = newRow.Cells[1].Value.ToString();
            txtAmt.Text = newRow.Cells[2].Value.ToString();
        }

        private void butDeleteLine_Click(object sender, EventArgs e)
        {
            selectedRow = DgvLine.CurrentCell.RowIndex;
            DgvLine.Rows.RemoveAt(selectedRow);
        }

        public static string docStr;
        private void butAddLine_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtLineNo.Text, txtQuant.Text, txtAmt.Text);
            DgvLine.DataSource = table;
            txtLineNo.Clear();
            txtQuant.Clear();
            txtAmt.Clear();
        }


        public TransactionForm(TaxSvc TaxService)
        {
            _taxService = TaxService;

            InitializeComponent();
        }


        private void butGetTax_Click(object sender, EventArgs e)
        {

            _taxService.Configuration.Url = "https://development.avalara.net/Tax/TaxSvc.asmx?GetTax";

            //Header Section Start
            CompCode = txtCompCode.Text;
            CustCode = txtCustCode.Text;
            DocCode = txtDocCode.Text;
            date = txtDate.Value.ToString();
            Dtype = cmbDocType.SelectedItem.ToString();
            ReturnValue_Company = SetCompanyDetails1(CompCode, CustCode, DocCode, date, Dtype);


            //Line Section Start
            ReturnValue_Line = SetLineDetails();

            //Address Section Start
            SfLine = txtSfLine.Text;
            StLine = txtStLine.Text;
            SfCity = txtSfCity.Text;
            StCity = txtStCity.Text;
            SfState = txtSfState.Text;
            StState = txtStState.Text;
            SfZip = txtSfZip.Text;
            StZip = txtStZip.Text;

            if ((SfLine.Equals("") && SfCity.Equals("") && SfState.Equals("") && SfZip.Equals("")) && (!StLine.Equals("") || !StCity.Equals("") || !StState.Equals("") || !StZip.Equals("")))
            {
                ReturnValue_Address = SetAddressDetailsOnlyShipTo(StLine, StCity, StState, StZip);
            }

            else if ((!SfLine.Equals("") || !SfCity.Equals("") || !SfState.Equals("") || !SfZip.Equals("")) && (StLine.Equals("") && StCity.Equals("") && StState.Equals("") && StZip.Equals("")))
            {
                ReturnValue_Address = SetAddressDetailsOnlyShipFrom(SfLine, SfCity, SfState, SfZip);
            }
            else
            {
                ReturnValue_Address = SetAddressDetails(SfLine, StLine, SfCity, StCity, SfState, StState, SfZip, StZip);
            }

            //Display Result Start
            getTaxResult = _taxService.GetTax(getTaxRequest);
            bool FinalResultValue;
            if (ReturnValue_Company == false || ReturnValue_Line == false || ReturnValue_Address == false)
            {
                FinalResultValue = false;
            }
            else
            {
                txtResultCode.Text = Convert.ToString(getTaxResult.ResultCode);
                txtResultDocCode.Text = getTaxResult.DocCode;
                txtResultDocDate.Text = Convert.ToString(getTaxResult.DocDate);
                txtResultTotTaxable.Text = Convert.ToString(getTaxResult.TotalTaxable);
                txtResultTotAmt.Text = Convert.ToString(getTaxResult.TotalAmount);
                txtTotalTax.Text = Convert.ToString(getTaxResult.TotalTax);
                txtResultTotDisc.Text = Convert.ToString(getTaxResult.TotalDiscount);
                txtResultTransId.Text = getTaxResult.TransactionId;
                FinalResultValue = true;
            }
            if (FinalResultValue == false)
            {
                MessageBox.Show(getTaxResult.Messages[0].Summary.ToString());
            }
        }

        public bool SetCompanyDetails1(string comp_code, string cust_code, string doc_code, string date_, string Dtype_)
        {
            try
            {
                if (DocCode == null && !comp_code.Equals("") && !cust_code.Equals("") && !Dtype_.Equals("") && !date_.Equals(""))
                {
                    getTaxRequest.CompanyCode = comp_code;
                    getTaxRequest.CustomerCode = cust_code;
                    getTaxRequest.DocDate = Convert.ToDateTime(date_);
                    docStr = Dtype_;
                    Enum.TryParse<Avalara.AvaTax.Adapter.TaxService.DocumentType>(docStr, out docType);
                    getTaxRequest.DocType = docType;
                    statusCmp = true;
                }
                else
                {
                    getTaxRequest.CompanyCode = comp_code;
                    getTaxRequest.CustomerCode = cust_code;
                    getTaxRequest.DocCode = doc_code;
                    getTaxRequest.DocDate = Convert.ToDateTime(date_);
                    docStr = Dtype_;
                    Enum.TryParse<Avalara.AvaTax.Adapter.TaxService.DocumentType>(docStr, out docType);
                    getTaxRequest.DocType = docType;
                    statusCmp = true;
                }
            }
            catch (Exception)
            {
                statusCmp = false;
            }

            return statusCmp;
        }

        public bool SetLineDetails()
        {
            int count = 1;
            string[,] myGridData = new string[(DgvLine.Rows.Count) - 1, (DgvLine.Columns.Count)];
            try
            {

                foreach (DataGridViewRow _row in DgvLine.Rows)
                {
                    if (count <= ((DgvLine.Rows.Count) - 1))
                    {
                        foreach (DataGridViewColumn col in DgvLine.Columns)
                        {
                            myGridData[_row.Index, col.Index] = DgvLine.Rows[_row.Index].Cells[col.Index].Value.ToString();
                        }
                        ++count;
                    }
                }

                int row;
                for (row = 0; row < DgvLine.Rows.Count - 1; row++)
                {
                    string quantity = myGridData[row, 1];
                    string amount = myGridData[row, 2];

                    Line lobj = new Line();
                    lno[row] = lobj;

                    if (quantity.Equals("") && amount.Equals(""))
                    {
                        lno[row].No = myGridData[row, 0];
                        getTaxRequest.Lines.Add(lno[row]);
                        statusLine = true;
                    }
                    else if (quantity.Equals("") && !amount.Equals(""))
                    {
                        lno[row].No = myGridData[row, 0];
                        lno[row].Amount = Convert.ToDecimal(amount);
                        getTaxRequest.Lines.Add(lno[row]);
                        statusLine = true;
                    }
                    else if (!quantity.Equals("") && amount.Equals(""))
                    {
                        lno[row].No = myGridData[row, 0];
                        lno[row].Qty = Convert.ToDouble(quantity);
                        getTaxRequest.Lines.Add(lno[row]);
                        statusLine = true;
                    }
                    else
                    {
                        lno[row].No = myGridData[row, 0];
                        lno[row].Qty = Convert.ToDouble(quantity);
                        lno[row].Amount = Convert.ToDecimal(amount);
                        getTaxRequest.Lines.Add(lno[row]);
                        statusLine = true;
                    }
                }
            }
            catch (Exception)
            {
                statusLine = false;
            }

            return statusLine;
        }

        public bool SetAddressDetails(string Sf_Line, string St_Line, string Sf_City, string St_City, string Sf_State, string St_State, string Sf_Zip, string St_Zip)
        {
            try
            {
                if (Sf_Line.Equals("") && St_Line.Equals("") && Sf_City.Equals("") && St_City.Equals("") && Sf_State.Equals("") && St_State.Equals("") && Sf_Zip.Equals("") && St_Zip.Equals(""))
                {
                    statusAdd = false;
                }
                else
                {
                    //ShipFrom
                    getTaxRequest.OriginAddress = new Avalara.AvaTax.Adapter.AddressService.Address();
                    getTaxRequest.OriginAddress.Line1 = Sf_Line;
                    getTaxRequest.OriginAddress.City = Sf_City;
                    getTaxRequest.OriginAddress.Region = Sf_State;
                    getTaxRequest.OriginAddress.PostalCode = Sf_Zip;
                    //ShipTo
                    getTaxRequest.DestinationAddress = new Avalara.AvaTax.Adapter.AddressService.Address();
                    getTaxRequest.DestinationAddress.Line1 = St_Line;
                    getTaxRequest.DestinationAddress.City = St_City;
                    getTaxRequest.DestinationAddress.Region = St_State;
                    getTaxRequest.DestinationAddress.PostalCode = St_Zip;
                    statusAdd = true;
                }
            }
            catch (Exception)
            {
                statusAdd = false;
            }
            return statusAdd;
        }
        public bool SetAddressDetailsOnlyShipTo(string St_Line, string St_City, string St_State, string St_Zip)
        {
            try
            {
                getTaxRequest.DestinationAddress = new Avalara.AvaTax.Adapter.AddressService.Address();

                if (!St_Line.Equals("") && !St_Zip.Equals(""))
                {
                    getTaxRequest.DestinationAddress.Line1 = St_Line;
                    getTaxRequest.DestinationAddress.PostalCode = St_Zip;
                    statusAdd = true;
                }
                else if (!St_Line.Equals("") && !St_City.Equals("") && !St_State.Equals(""))
                {
                    getTaxRequest.DestinationAddress.Line1 = St_Line;
                    getTaxRequest.DestinationAddress.City = St_City;
                    getTaxRequest.DestinationAddress.Region = St_State;
                    statusAdd = true;
                }
                else
                {
                    getTaxRequest.DestinationAddress.Line1 = St_Line;
                    getTaxRequest.DestinationAddress.City = St_City;
                    getTaxRequest.DestinationAddress.Region = St_State;
                    getTaxRequest.DestinationAddress.PostalCode = St_Zip;
                    statusAdd = true;
                }
            }
            catch (Exception)
            {
                statusAdd = false;
            }
            return statusAdd;
        }
        public bool SetAddressDetailsOnlyShipFrom(string Sf_Line, string Sf_City, string Sf_State, string Sf_Zip)
        {
            try
            {
                getTaxRequest.OriginAddress = new Avalara.AvaTax.Adapter.AddressService.Address();

                if (!Sf_Line.Equals("") && !Sf_Zip.Equals(""))
                {
                    getTaxRequest.OriginAddress.Line1 = Sf_Line;
                    getTaxRequest.OriginAddress.PostalCode = Sf_Zip;
                    statusAdd = true;
                }
                else if (!Sf_Line.Equals("") && !Sf_City.Equals("") && !Sf_State.Equals(""))
                {
                    getTaxRequest.OriginAddress.Line1 = Sf_Line;
                    getTaxRequest.OriginAddress.City = Sf_City;
                    getTaxRequest.OriginAddress.Region = Sf_State;
                    statusAdd = true;
                }
                else
                {
                    getTaxRequest.OriginAddress.Line1 = Sf_Line;
                    getTaxRequest.OriginAddress.City = Sf_City;
                    getTaxRequest.OriginAddress.Region = Sf_State;
                    getTaxRequest.OriginAddress.PostalCode = Sf_Zip;
                    statusAdd = true;
                }

            }
            catch (Exception)
            {
                statusAdd = false;
            }
            return statusAdd;
        }
        private void butLoadDefault_Click(object sender, EventArgs e)
        {
            cmbDocType.Text = "SalesInvoice";
            txtCompCode.Text = "AkshayaShelke";
            txtSfCity.Text = "BI";
            txtSfLine.Text = "900 winslow way e";
            txtSfState.Text = "WA";
            txtSfZip.Text = "98110";
            txtStCity.Text = "BI";
            txtStLine.Text = "900 winslow way e";
            txtStState.Text = "WA";
            txtStZip.Text = "98110";
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            txtCompCode.Clear();
            txtCustCode.Clear();
            txtDocCode.Clear();
            txtSfCity.Clear();
            txtSfLine.Clear();
            txtSfState.Clear();
            txtSfZip.Clear();
            txtStCity.Clear();
            txtStLine.Clear();
            txtStState.Clear();
            txtStZip.Clear();
            txtLineNo.Clear();
            txtQuant.Clear();
            txtAmt.Clear();
            cmbDocType.Text = "";
        }
    }
}
