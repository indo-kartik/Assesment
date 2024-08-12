using Microsoft.AspNetCore.Mvc;
using PayerAPI.Model;

namespace PayerAPI.Service
{
    public interface PayerInterface
    {
        public PayerModel GetAll();
    }
}
