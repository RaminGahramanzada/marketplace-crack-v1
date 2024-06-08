using System;
using marketplace_crack_v1.models.companies;

namespace marketplace_crack_v1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            services.IPhonesManager phonesManager = new services.impl.PhonesManager();

           
            models.Phones samsungPhone = new Samsung()
            {
                Id = 1,
                CompanyName = "Samsung",
                Price = 899.99,
                ProductName = "Galaxy S21",
                Color = "Phantom Gray",
                ModelCode = "SM-G991U",
                ScreenSize = "6.2 inches",
                InternalMemory = "128GB",
                OperatingMemory = "8GB",
                MainCamera = "12 MP",
                FaceCamera = "10 MP",
                NumberOfSimCards = 1,
                ProcessorName = "Exynos 2100",
                AndroidVersion = "Android 11"
            };

            models.Phones applePhone = new Apple()
            {
                Id = 2,
                CompanyName = "Apple",
                Price = 1099.99,
                ProductName = "iPhone 12 Pro",
                Color = "Pacific Blue",
                ModelCode = "A2341",
                ScreenSize = "6.1 inches",
                InternalMemory = "256GB",
                OperatingMemory = "6GB",
                MainCamera = "12 MP",
                FaceCamera = "12 MP",
                NumberOfSimCards = 1,
                ProcessorName = "Apple A14 Bionic",
                IOSVersion = "iOS 14.5"
            };

            // Add phones
            phonesManager.AddProduct(samsungPhone);
            phonesManager.AddProduct(applePhone);

            // List all phones
            Console.WriteLine("All Phones:");
            foreach (var phone in phonesManager.GetAllProducts())
            {
                Console.WriteLine($"ID: {phone.Id}, Company: {phone.CompanyName}, Model: {phone.ProductName}");
            }
            
            // Update a phone
            samsungPhone.ProductName = "Galaxy S21 Ultra";
            phonesManager.UpdateProduct(samsungPhone);

            // list for updated phones
            Console.WriteLine("\nAll Phones After Update:");
            foreach (var phone in phonesManager.GetAllProducts())
            {
                Console.WriteLine($"ID: {phone.Id}, Company: {phone.CompanyName}, Model: {phone.ProductName}");
            }

            // delete phone
            phonesManager.DeleteProduct(applePhone.Id);

            // list after delete
            Console.WriteLine("\nAll Phones After Deletion:");
            foreach (var phone in phonesManager.GetAllProducts())
            {
                Console.WriteLine($"ID: {phone.Id}, Company: {phone.CompanyName}, Model: {phone.ProductName}");
            }
        }
    }
}
