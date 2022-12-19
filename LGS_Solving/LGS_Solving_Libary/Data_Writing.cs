namespace LGS_Solving_Libary;

interface IDataWriter<T>
{
    void Write(T data);
}

internal class Data_Writing: IDataWriter<double>
{
    public void Write(double T)
    {

    }
}
