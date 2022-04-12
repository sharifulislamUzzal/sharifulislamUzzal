using NUnit.Framework;
using System;
using System.Reflection;
using Task2;
using System.Collections.Generic;

namespace Task2Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetInfo_ValidLists_MergesData()
        {
            DataMerge dataMerge = new();
            dataMerge.CustomerList = new();
            dataMerge.OrderList = new();

            dataMerge.CustomerList.Add(new Customer { Id = 1, Name = "Person1", Address ="Dhaka" });
            dataMerge.CustomerList.Add(new Customer { Id = 2, Name = "Person2", Address = "Sylhet" });
            dataMerge.CustomerList.Add(new Customer { Id = 3, Name = "Person3", Address = "Khulna" });

            dataMerge.OrderList.Add(new Order { CustomerId = 3, Products = new List<Product> {
                new Product { Id = 1, Name = "Camera", Price = 13000 },
                new Product { Id = 2, Name = "Laptop", Price = 50000 },
                new Product { Id = 3, Name = "Monitor", Price = 6000 },
            } });
            dataMerge.OrderList.Add(new Order { CustomerId = 2, Products = new List<Product> {
                new Product { Id = 1, Name = "Camera", Price = 13000 },
                new Product { Id = 4, Name = "Keyboard", Price = 500 },
                new Product { Id = 5, Name = "Mouse", Price = 100 },
            } });
            dataMerge.OrderList.Add(new Order { CustomerId = 3, Products = new List<Product> {
                new Product { Id = 1, Name = "Camera", Price = 13000 },
                new Product { Id = 6, Name = "Pend Drive", Price = 300 }
            }  });

            var result = dataMerge.GetInfo();

            Assert.AreEqual("Person3", result[0].customerName);
            Assert.AreEqual("Camera", result[0].productNames[0]);
            Assert.AreEqual("Laptop", result[0].productNames[1]);
            Assert.AreEqual("Monitor", result[0].productNames[2]);

            Assert.AreEqual("Person2", result[1].customerName);
            Assert.AreEqual("Camera", result[1].productNames[0]);
            Assert.AreEqual("Keyboard", result[1].productNames[1]);
            Assert.AreEqual("Mouse", result[1].productNames[2]);

            Assert.AreEqual("Person3", result[2].customerName);
            Assert.AreEqual("Camera", result[2].productNames[0]);
            Assert.AreEqual("Pend Drive", result[2].productNames[1]);
        }
    }
}