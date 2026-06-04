namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class PaymentService
{
    private readonly PaymentRepository _paymentRepository = new();

    public IReadOnlyList<Payment> GetRecentPayments(int take = 20)
    {
        return _paymentRepository.GetRecentPayments(take);
    }
}
