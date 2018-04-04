namespace VTexConnector.Entity
{
    public class OrderStatus
    {
        internal static string WaitingForSellerConfirmation => "Waiting-for-seller-confirmation";
        internal static string ProcessingOrderCreated => "Order-created";
        internal static string ProcessingOrderCompleted => "Order-completed";
        internal static string ProcessingOnOrderCompleted => "On-order-completed";
        internal static string PaymentPending => "Payment-pending";
        internal static string WaitingForOrderAuthorization => "Waiting-for-order-authorization";
        internal static string PaymentApproved => "Payment-approved";
        internal static string PaymentDenied => "Payment-denied";
        internal static string RequestCancellation => "Request-cancel";
        internal static string WaitingForSellerDecision => "Waiting-for-seller-decision";
        internal static string AuthorizeFulfillment => "Authorize-fulfillment";
        internal static string OrderCreateError => "Order-create-error";
        internal static string OrderCreationError => "Order-creation-error";
        internal static string WindowToCancellation => "Window-to-cancel";
        internal static string ReadyForHandling => "Ready-for-handling";
        internal static string StartHandling => "Start-handling";
        internal static string Handling => "Handling";
        internal static string RequestCancel => "Request-cancel";
        internal static string InvoiceAfterCancellationDeny => "Invoice-after-cancellation-deny";
        internal static string OrderAccepted => "Order-accepted";
        internal static string Invoiced => "Invoiced";
        internal static string Cancel => "Cancel";
        internal static string Canceled => "Canceled";
    }
}
