
class IPV4
{
    byte  MessageSize;
    byte  PackSize;

    public IPV4(byte MessageSize, byte PackSize)
    {
        this.MessageSize = MessageSize;
        this.PackSize = PackSize;
    }
    public IPV4() { }


    public byte GetMessageSize()
    {
        return MessageSize;
    }
    public byte GetPackSize()
    {
        return PackSize;
    }
    public void SetMessageSize(byte MessageSize)
    {
        this.MessageSize = MessageSize;
    }
    public void SetPackSize(byte PackSize)
    {
        this.PackSize = PackSize;
    }
   



}



class MyClass
{
    static void Main()
    {

    }
}
