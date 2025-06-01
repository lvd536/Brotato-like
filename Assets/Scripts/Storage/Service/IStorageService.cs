using UnityEngine;

public interface IStorageService
{
    public void Save(object obj);
    public object Load();
}
