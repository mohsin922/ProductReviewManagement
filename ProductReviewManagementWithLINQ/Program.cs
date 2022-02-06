using System;
using System.Collections.Generic;
using System.Linq;


namespace ProductReviewManagementWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problem Statement !");
            //UC-1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=10,Review="Blockbuster",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=3,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=6,UserID=4,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=7,UserID=3,Rating=1.5,Review="nice",isLike=false},
                new ProductReview(){ProductID=8,UserID=10,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=8,UserID=10,Rating=9,Review="Blockbuster",isLike=true},
                new ProductReview(){ProductID=10,UserID=10,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=11,UserID=10,Rating=7,Review="Hit",isLike=true},
                new ProductReview(){ProductID=11,UserID=10,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=13,UserID=10,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=14,UserID=10,Rating=8,Review="Super",isLike=true},
                new ProductReview(){ProductID=15,UserID=10,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=16,UserID=10,Rating=6,Review="Hit",isLike=true},

            };
            //foreach (var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            //}
            Management management = new Management();
            //UC2
            //management.TopRecords(productReviewList);

            //UC3
            //management.SelectRecords(productReviewList);

            //UC4
            //management.RetrieveCountOfRecords(productReviewList);

            //UC5
            //management.RetrieveProductID(productReviewList);

            //UC6
            management.SkipTopFive(productReviewList);
        }
    }
}
