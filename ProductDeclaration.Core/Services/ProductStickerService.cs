using ProductDeclaration.Core.DataAccess.Repository;
using ProductDeclaration.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDeclaration.Core.Services
{
    public class ProductDeclarationService
    {
        private IDeclarationRepository _productRepository;

        public ProductDeclarationService(IDeclarationRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public DataTable CreateDataTable(StoreModel store, DocumentModel document, int fromDocument, int toDocument, int emptySpace)
        {
            DataTable dt = new DataTable("Products");
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Unit");
            dt.Columns.Add("Supplier");
            dt.Columns.Add("Manufacturer");
            dt.Columns.Add("ExpiryDay");
            dt.Columns.Add("ManufacturerCountry");
            dt.Columns.Add("WholesalePrice");
            dt.Columns.Add("RetailPrice");

            List<ProductModel> products = _productRepository.GetProducts(document, fromDocument,
                toDocument, store.StoreId);

            for (int i = 0; i < Convert.ToInt32(emptySpace); i++)
                dt.Rows.Add(new Object[] { null, null, null, null, null, null, null, null });

            SetProductsInDataTable(products, ref dt);

            return dt;
        }
        private void SetProductsInDataTable(List<ProductModel> products, ref DataTable dt)
        {
            foreach (ProductModel model in products)
            {
                if (model.DeclarationType == 0)
                {
                    for (int i = 0; i < Convert.ToInt32(model.Amount); i++)
                    {
                        dt.Rows.Add(new Object[]
                        {
                            model.Id,
                            model.Name,
                            model.Unit,
                            model.Supplier,
                            model.Manufacturer,
                            model.ExpiryDay,
                            model.ManufacturerCountry,
                            model.WholesalePrice,
                            model.RetailPrice
                        });
                    }
                }
                else if (model.DeclarationType == 1)
                {
                    dt.Rows.Add(new Object[]
                        {
                            model.Id,
                            model.Name,
                            model.Unit,
                            model.Supplier,
                            model.Manufacturer,
                            model.ExpiryDay,
                            model.ManufacturerCountry,
                            model.WholesalePrice,
                            model.RetailPrice
                        });
                }
            }
        }
    }
    
}
