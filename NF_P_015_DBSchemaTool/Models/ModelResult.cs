namespace NF_P_015_DBSchemaTool.Models
{
    public class ModelResult
    {
        public bool IsOk { get; set; }
    }

    public class ModelResult<T> : ModelResult
    {
        public T Data { get; set; }
    }
}