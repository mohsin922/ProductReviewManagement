using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace ProductReviewManagementWithLINQ
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        ///<summary>
        /// UC-2
        /// </summary>
        /// <param name="listProductReview"></param>
        public void TopRecords(List<ProductReview> listproductReview)
        {
            var recordedData = (from ProductReview in listproductReview
                                orderby ProductReview.Rating descending
                                select ProductReview).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }

        ///<summary>
        /// UC-3
        /// </summary>
        /// <param name="listProductReview"></param>
        public void SelectRecords(List<ProductReview> listproductReview)
        {
            var recordedData = from ProductReview in listproductReview
                               where (ProductReview.ProductID == 1 || ProductReview.ProductID == 4 || ProductReview.ProductID == 9)
                               && ProductReview.Rating > 3
                               select ProductReview;

            //(ProductReview.ProductID == 1 && ProductReview.Rating > 3) ||
            //(ProductReview.ProductID == 4 && ProductReview.Rating > 3) ||
            //(ProductReview.ProductID == 9 && ProductReview.Rating > 3)
            // select ProductReview;

            foreach(var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }

        ///<summary>
        /// UC-4
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RetrieveCountOfRecords(List<ProductReview> listproductReview)
        {
            var recordedData = listproductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "--------" + list.Count);
            }

        }
        ///<summary>
        /// UC-5
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RetrieveProductID(List<ProductReview> listProductReview)
        {
            var recordedData = (from list in listProductReview
                                select new { list.ProductID, list.Review });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ToString());
            }

        }
    }
}
