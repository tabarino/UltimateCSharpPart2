using System;

namespace AssociationBetweenClasses
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {
            _logger.Log("Installing the Application...");
        }
    }
}
