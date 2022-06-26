namespace Course.Entities.Enums
{
    enum OrderStatus
    {
        PendingPayment = 0, 
        Processing = 1,
        Shipped = 2,    // shipped = enviado
        Delivered = 3
    }
}