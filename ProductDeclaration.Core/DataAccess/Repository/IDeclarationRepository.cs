using ProductDeclaration.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDeclaration.Core.DataAccess.Repository
{
    public interface IDeclarationRepository
    {
        List<ProductModel> GetProducts(DocumentModel model, int documentStart, int documentFinish, int storeId);
        List<StoreModel> GetAllStores();
        StoreModel GetStoreByName(string storeName);
        List<DocumentModel> GetRetailDocuments(int structId);
        List<DocumentModel> GetWholesaleDocuments(int structId);
        int MaxDocumentNumber(int structId);
    }
}
