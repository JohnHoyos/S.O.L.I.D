using OpenClose_example;

ShowDiscount(new List<Client>() {
    new ClientVIP("Pepito Pérez",10000),
    new ClientRegular("Manuel Lopera",50000)
});

void ShowDiscount(List<Client> clientList)
{
    foreach (var client in clientList)
    {
        
            Console.WriteLine($"Cliente: {client.Name}, Pago: {client.CalculateDiscount():C1} ");
    }
}