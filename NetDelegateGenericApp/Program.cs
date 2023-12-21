using NetDelegateGenericApp;
using System.Threading.Channels;

// Generic Delegates

//void DelegateGenericExample()
//{
//    OperInt operInt = Sum;
//    OperFloat operFloat = Square;

//    OperGen<int> operGenInt = Sum;
//    OperGen<float> operGenFloat = Square;

//    FuncDelegate<int, float> funcDelegate1 = Func1;
//    FuncDelegate<double, int> funcDelegate2 = Func2;

//    int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    float Square(float w, float h)
//    {
//        return w * h;
//    }


//    int Func1(int x, float y)
//    {
//        return x + (int)y;
//    }

//    double Func2(double x, int y)
//    {
//        return x + y;
//    }

//}

//delegate T1 FuncDelegate<T1, T2>(T1 x, T2 y);

//delegate T OperGen<T>(T x, T y);

//delegate int OperInt(int x, int y);
//delegate float OperFloat(float x, float y);


// Covariance Generic delegates
//MessageBuilder<Message> messageBuilder = MessageWriter;
//var messageObj = messageBuilder("Hello world");
//messageObj.Print();

//messageBuilder = EmailMessageWriter;
//var messageObj2 = messageBuilder("Hello people");
//messageObj2.Print();


//Message MessageWriter(string message) => new Message(message);
//EmailMessage EmailMessageWriter(string message) => new EmailMessage(message);

//delegate T MessageBuilder<out T>(string text);


//MessageReceiver<Message> messageReceiver = MessagePrint;
//MessageReceiver<EmailMessage> emailMessageReceiver = EmailMessagePrint;

//messageReceiver(new EmailMessage("Hello world"));
//messageReceiver(new Message("Hello world"));

//emailMessageReceiver = messageReceiver;
//emailMessageReceiver(new EmailMessage("Hello people"));
//emailMessageReceiver(new Message("Hello people"));


//void MessagePrint(Message message)
//{
//    message.Print();
//}

//void EmailMessagePrint(EmailMessage message)
//{
//    message.Print();
//}

//delegate void MessageReceiver<in T>(T message);