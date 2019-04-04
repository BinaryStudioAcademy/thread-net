using System;

namespace Thread_.NET.BLL.Exceptions
{
    public sealed class NotFoundException : Exception
    {
        public NotFoundException(string name, int id)
            : base($"Entity {name} with id ({id}) was not found.")
        {
        }
    }
}
