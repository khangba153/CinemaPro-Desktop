namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class PaymentRepository
{
    public void InsertSuccessfulPayment(SqlConnection connection, SqlTransaction transaction, string paymentCode, int ticketId, string paymentMethod, decimal amount)
    {
        using var command = new SqlCommand("""
            INSERT INTO dbo.Payments
            (
                PaymentCode,
                TicketId,
                PaymentMethod,
                Amount,
                Status,
                TransactionRef,
                PaidAt
            )
            VALUES
            (
                @PaymentCode,
                @TicketId,
                @PaymentMethod,
                @Amount,
                N'Success',
                @TransactionRef,
                SYSDATETIME()
            );
            """, connection, transaction);

        command.Parameters.AddWithValue("@PaymentCode", paymentCode);
        command.Parameters.AddWithValue("@TicketId", ticketId);
        command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
        command.Parameters.AddWithValue("@Amount", amount);
        command.Parameters.AddWithValue("@TransactionRef",
            paymentMethod == PaymentMethodHelper.VnPaySandbox ? $"VNPAY-DEMO-{paymentCode}" :
            paymentMethod == PaymentMethodHelper.MomoSandbox ? $"MOMO-DEMO-{paymentCode}" :
            DBNull.Value);
        command.ExecuteNonQuery();
    }

    public IReadOnlyList<Payment> GetRecentPayments(int take = 20)
    {
        const string sql = """
            SELECT TOP (@Take)
                PaymentId,
                PaymentCode,
                TicketId,
                PaymentMethod,
                Amount,
                Status,
                TransactionRef,
                PaidAt,
                CreatedAt
            FROM dbo.Payments
            ORDER BY CreatedAt DESC;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql, new SqlParameter("@Take", take));
        var payments = new List<Payment>();

        foreach (DataRow row in table.Rows)
        {
            payments.Add(new Payment
            {
                PaymentId = Convert.ToInt32(row["PaymentId"]),
                PaymentCode = row["PaymentCode"].ToString() ?? "",
                TicketId = Convert.ToInt32(row["TicketId"]),
                PaymentMethod = row["PaymentMethod"].ToString() ?? "",
                Amount = Convert.ToDecimal(row["Amount"]),
                Status = row["Status"].ToString() ?? "",
                TransactionRef = row["TransactionRef"].ToString() ?? "",
                PaidAt = row["PaidAt"] == DBNull.Value ? null : Convert.ToDateTime(row["PaidAt"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            });
        }

        return payments;
    }
}
