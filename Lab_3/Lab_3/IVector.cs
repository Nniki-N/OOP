

namespace Lab_3
{
    public interface IVector
    {
        double Length();
        IVector Sum(IVector vector);
        IVector MultiplyByNumber(double number);
        double DotProduct(IVector vector);
    }
}
