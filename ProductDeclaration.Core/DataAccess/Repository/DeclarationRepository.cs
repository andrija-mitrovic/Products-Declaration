using ProductDeclaration.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace ProductDeclaration.Core.DataAccess.Repository
{
    public class DeclarationRepository: IDeclarationRepository
    {
        public List<ProductModel> GetProducts(DocumentModel model, int documentStart, int documentFinish, int storeId)
        {
            List<ProductModel> products;

            using (IDbConnection connection = DbConnection.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@StructId", model.StructId);
                p.Add("@DocIdStart", documentStart);
                p.Add("@DocIdFinish", documentFinish);
                p.Add("@StoreId", storeId);

                products = connection.Query<ProductModel>("spGetProducts", p, 
                    commandType: CommandType.StoredProcedure).ToList();
            }

            return products;
        }

        public List<StoreModel> GetAllStores()
        {
            List<StoreModel> stores;

            using(IDbConnection connection = DbConnection.GetConnection())
            {
                stores = connection.Query<StoreModel>("spGetAllStores").ToList();
            }

            return stores;
        }

        public StoreModel GetStoreByName(string storeName)
        {
            StoreModel store;
            using(IDbConnection connection = DbConnection.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@StoreName", storeName);

                store = connection.Query<StoreModel>("spGetStoresByName", p,
                    commandType: CommandType.StoredProcedure).ToList()[0];
            }

            return store;
        }

        public List<DocumentModel> GetRetailDocuments(int structId)
        {
            List<DocumentModel> documents;
            using(IDbConnection connection = DbConnection.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@Id", structId);

                documents = connection.Query<DocumentModel>("spGetRetailDoc", p,
                    commandType: CommandType.StoredProcedure).ToList();
            }

            return documents;
        }

        public List<DocumentModel> GetWholesaleDocuments(int Id)
        {
            List<DocumentModel> documents;
            using (IDbConnection connection = DbConnection.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@Id", Id);

                documents = connection.Query<DocumentModel>("spGetWholesaleDoc", p,
                    commandType: CommandType.StoredProcedure).ToList();
            }

            return documents;
        }

        public int MaxDocumentNumber(int Id)
        {
            int maxNumber = 0;
            using(IDbConnection connection = DbConnection.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@Id", Id);

                maxNumber = connection.Query<DocumentModel>("spMaxDocumentId", p,
                    commandType: CommandType.StoredProcedure).ToList()[0].DocumentId;
            }

            return maxNumber;
        }
    }
}
