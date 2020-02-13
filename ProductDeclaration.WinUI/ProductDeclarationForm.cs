using ProductDeclaration.Core.DataAccess.Repository;
using ProductDeclaration.Core.Models;
using ProductDeclaration.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductDeclaration.WinUI
{
    public partial class ProductDeclarationForm : Form
    {
        private IDeclarationRepository _productRepository;
        private bool wholesale = true;
        private int wholesaleTrushold = 20;

        public ProductDeclarationForm(IDeclarationRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;

            this.KeyDown += ProductStickerForm_KeyDown;
            this.Load += ProductStickerForm_Load;
            this.documentType.GotFocus += DocumentType_GotFocus;
            this.documentType.Leave += DocumentType_Leave;
            this.accept.Click += Accept_Click;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            StoreModel store = (StoreModel)this.storeTypes.SelectedItem;
            DocumentModel document = (DocumentModel)this.documentType.SelectedItem;

            ProductDeclarationService productService = new ProductDeclarationService(_productRepository);
            DataTable dt = productService.CreateDataTable(store, document, Convert.ToInt32(this.fromNumber.Text), 
                Convert.ToInt32(this.toNumber.Text), Convert.ToInt32(emptySpace.Text));

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no declaration...", "Attention!");
                this.Close();
            }
            else
            {
                //dt.WriteXmlSchema("dsdecl.xsd");
                string rptName = (wholesale == false) ? "c_rdecl.rpt": "c_wdecl.rpt";
                Form F = new ReportForm(rptName, dt);
                F.Show();
            }

            ClearFileds();
        }

        private void DocumentType_Leave(object sender, EventArgs e)
        {
            int structId = ((DocumentModel)this.documentType.SelectedItem).StructId;

            int maxDocumentId = _productRepository.MaxDocumentNumber(structId);

            this.fromNumber.Text = maxDocumentId.ToString();
            this.toNumber.Text = maxDocumentId.ToString();
        }

        private void DocumentType_GotFocus(object sender, EventArgs e)
        {
            this.documentType.Items.Clear();
            string storeName = this.storeTypes.Text.Trim(' ');
            int storeNameLength = this.storeTypes.Text.Trim(' ').Length;

            StoreModel selectedStore = (StoreModel)this.storeTypes.SelectedItem;

            wholesale = (selectedStore.StoreType == 0) ? true : false;

            List<DocumentModel> documents;

            documents=(wholesale==true)?
                _productRepository.GetWholesaleDocuments(wholesaleTrushold):
                _productRepository.GetRetailDocuments(wholesaleTrushold);

            foreach (DocumentModel document in documents)
            {
                if (document.Name.Trim(' ') != "")
                {
                    documentType.Items.Add(document);
                    documentType.DisplayMember = "Name";
                }
            }

            documentType.SelectedIndex = 0;
        }

        private void ProductStickerForm_Load(object sender, EventArgs e)
        {
            List<StoreModel> stores = _productRepository.GetAllStores();

            foreach(StoreModel store in stores)
            {
                storeTypes.Items.Add(store);
                storeTypes.DisplayMember = "FullName";
            }

            storeTypes.SelectedIndex = 0;
        }

        private void ProductStickerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ClearFileds()
        {
            this.emptySpace.Text = "0";
            this.fromNumber.Text = "";
            this.toNumber.Text = "";
            this.storeTypes.SelectedIndex = 0;
            this.documentType.SelectedIndex = 0;
        }
    }
}
