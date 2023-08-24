EmailService emailService = new EmailService();
var responseSender = emailService.GetBySender("jane@example.com", 5, 1);
/*foreach (var item in responseSender)
    Console.WriteLine($"ReceiverAddress:{item.ReceiverAddress}\nSenderAddress: {item.SenderAddress}\nSubject: {item.Subject}\nBody:{item.Body}\nDate:{item.Date}\nIsClassified:{item.IsClassified}\n");
*/
var responseReciver = emailService.GetByReceiver("kevin@example.com", 4, 1);
foreach (var item in responseReciver)
Console.WriteLine($"ReceiverAddress:{item.ReceiverAddress}\nSenderAddress: {item.SenderAddress}\nSubject: {item.Subject}\nBody:{item.Body}\nDate:{item.Date}\nIsClassified:{item.IsClassified}\n");