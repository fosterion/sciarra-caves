using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Core.Services
{
    public interface IBattleService
    {
        public void Start();
    }

    public class BattleService : IBattleService
    {
        private readonly IDamageService _damageService;

        public BattleService(IDamageService damageService)
        {
            _damageService = damageService;
        }

        public void Start()
        {
            _damageService.SayHello();
        }
    }
}
