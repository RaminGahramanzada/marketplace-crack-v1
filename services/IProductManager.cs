using marketplace_crack_v1.models;

namespace marketplace_crack_v1.services;

public interface IPhonesManager
{
    IEnumerable<Phones> GetAllProducts();
    Phones GetProductById(int id);
    void AddProduct(Phones product);
    void UpdateProduct(Phones product);
    void DeleteProduct(int id);
}