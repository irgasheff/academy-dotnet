public static class ArrayHelper
{
    public static int[] Add(int[] root, int element)
    {
        int newArrayLength = root.Length + 1;
        int newElementIdx = newArrayLength - 1;

        int[] resultArray = new int[newArrayLength];
        root.CopyTo(resultArray, index: 0);
        resultArray[newElementIdx] = element;
        return resultArray;
    }

    public static void AddWithRef(ref int[] root, int element)
    {
        int newArrayLength = root.Length + 1;
        int newElementIdx = newArrayLength - 1;

        int[] resultArray = new int[newArrayLength];
        root.CopyTo(resultArray, index: 0);
        resultArray[newElementIdx] = element;

        root = resultArray;
    }

    public static void AddExt(this int[] root, ref int[] outputArray, int element)
    {
        int newArrayLength = root.Length + 1;
        int newElementIdx = newArrayLength - 1;

        int[] resultArray = new int[newArrayLength];
        root.CopyTo(resultArray, index: 0);
        resultArray[newElementIdx] = element;

        outputArray = resultArray;
    }

    public static int[] RemoveLast(int[] root)
    {
        int newArrayLength = root.Length - 1;
        int[] newArray = new int[newArrayLength];
        
        for(int i = 0; i < newArrayLength; i++)
        {
            newArray[i] = root[i];
        }

        return newArray;
    }

    public static void RemoveLastWithRef(ref int[] root)
    {
        int newArrayLength = root.Length - 1;
        int[] newArray = new int[newArrayLength];

        for (int i = 0; i < newArrayLength; i++)
        {
            newArray[i] = root[i];
        }
        root = newArray;
    }

    public static int[] RemoveByIndex(int[] root, int index)
    {
        int newArrayLength = root.Length - 1;
        int[] newArray = new int[newArrayLength];

        int newArrayIndex = 0;
        for (int i = 0; i < root.Length; i++)
        {
            if (i != index)
            {
                newArray[newArrayIndex] = root[i];
                newArrayIndex++;
            }
        }

        return newArray;
    }

    public static void RemoveByIndexWithRef(ref int[] root, int index)
    {
        int newArrayLength = root.Length - 1;
        int[] newArray = new int[newArrayLength];

        int newArrayIndex = 0;
        for (int i = 0; i < root.Length; i++)
        {
            if (i != index)
            {
                newArray[newArrayIndex] = root[i];
                newArrayIndex++;
            }
        }

        root = newArray;
    }

    public static int GetElementByIndex(int[] root, int index)
    {
        return root[index];
    }

    public static int GetFirstElement(int[] root)
    {
        return root[0];
    }

    public static int GetLastElement(int[] root) 
    {
        return root[root.Length - 1];
    }

    public static int GetElementFromTheMiddle(int[] root) 
    {
        int middleIndex = root.Length / 2;
        return root[middleIndex];
    }
}