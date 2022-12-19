namespace LGS_Solving_Libary
{
    interface IDataGathering<T>
    {
        IEnumerable<T> GetData();
    }

    interface IDataManipulatior<T, V>
    {
        V Manipulate(T data);
    }

    interface IDataWriter<T>
    {
        void Write(T data);
    }
    public class Class1
    {

    }
}