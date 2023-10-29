    
namespace Custom_GenericList
{
    public class CustomList<T>  
    {
        T[] objects = new T[10];
        public void Add(T obj)
        {
            if (objects[objects.Length - 1 ] != null)
            {
                Array.Resize(ref objects, objects.Length + 10);
            }
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i] = obj;
                break;
            }
        }
        public T[] Get()
        {
            return objects;
        }
    }
}
