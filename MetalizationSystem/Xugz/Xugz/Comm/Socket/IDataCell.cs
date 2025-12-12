namespace Xugz
{
    public interface IDataCell
    {
        byte[] ToBuffer();
        void FromBuffer(byte[] buffer);
    }
}
