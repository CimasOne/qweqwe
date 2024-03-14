using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CAR
{
    internal class Car
    {
        private const string ENGINE_IS_STARTED_MASSAGE = "Двигатель запущен!";
        private const string ATTEMPT_TO_START_ENGINE_MASSAGE = "Завожу двигатель!";
        private const string ENGINE_HAS_ALREADY_STARTED_MASSAGE = "Стоп,двигатель уже запущен!";
        private const string ATTEMPT_TO_DRIVE_MASSAGE = "По газам!";
        private const string DRIVE_MASSAGE = "Двинули!";
        private const string DRIVE_ERROR_MASSAGE = "Стой,сначалo заведи двигатель!";

        private readonly MyLogger _myLogger;

        private bool isEngineStarted;

        public Car(MyLogger myLogger) 
        {
            _myLogger = myLogger;
        }

        public void StartEngine()
        {
            _myLogger.Info(ATTEMPT_TO_START_ENGINE_MASSAGE);
            if (isEngineStarted)
            {
                _myLogger.Warn(ENGINE_HAS_ALREADY_STARTED_MASSAGE);
            }
            else
            {
                isEngineStarted = true;
                _myLogger.Info(ENGINE_IS_STARTED_MASSAGE);
            }
        }
        public void Drive()
        {
            _myLogger.Info(ATTEMPT_TO_DRIVE_MASSAGE);
            if (isEngineStarted)
                _myLogger.Info(DRIVE_MASSAGE);
            else
                _myLogger.Error(DRIVE_ERROR_MASSAGE);
        }
    }
}
