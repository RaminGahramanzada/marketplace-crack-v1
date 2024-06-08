using marketplace_crack_v1.models;

namespace marketplace_crack_v1.services.impl;

public class PhonesManager : IPhonesManager
{
    private List<Phones> _phones = new List<Phones>();
    public IEnumerable<Phones> GetAllProducts()
    {
        return _phones;
    }

    public Phones GetProductById(int id)
    {
        return _phones.FirstOrDefault(p => p.Id == id) ?? throw new InvalidOperationException();
    }

    public void AddProduct(Phones phones)
    {
        _phones.Add(phones);
        Console.WriteLine("Product Added");
    }

    public void UpdateProduct(Phones phones)
    {
        var existingPhones = _phones.FirstOrDefault(p => p.Id == phones.Id);
        if (existingPhones != null)
        {
            existingPhones.ProductName = phones.ProductName;
            existingPhones.CompanyName = phones.CompanyName;
            Console.WriteLine("Product Updated");
            
        }
    }

    public void DeleteProduct(int id)
    {
        var phones = _phones.FirstOrDefault(p => p.Id ==id);
        if (phones != null)
        {
            _phones.Remove(phones);
            Console.WriteLine("Product Removed");
        }
        
    }
}