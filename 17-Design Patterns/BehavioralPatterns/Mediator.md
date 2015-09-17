## Behavioral Design Patterns

### **Mediator** ###

##### Мотивация
Mediator е модел дизайн, който спомага за разхлабването на връзките между обектите чрез премахване на необходимостта от класове да комуникират помежду си директно. Вместо това, посреднически обекти се използват за капсулиране и централизиране на взаимодействията между класовете.
##### Цел

 
##### Приложение
В този модел на комуникацията между обекти е капсулирана с медиатор обект. Вместо класовете  да комуникират директно, класове изпращат съобщения на медиатора и медиаторът изпраща тези съобщения на другите класове.

##### Имплементация

```c#    
public interface IAirTrafficControl
    {
        void RegistrerAircraft(Aircraft aircraft);

        void SendWarningMessage(Aircraft aircraft);
    }

public class RegionalAirTrafficControl : IAirTrafficControl
    {
        private readonly List<Aircraft> registeredAircrafts = new List<Aircraft>();

        public void RegistrerAircraft(Aircraft aircraft)
        {
            if (!this.registeredAircrafts.Contains(aircraft))
            {
                this.registeredAircrafts.Add(aircraft);
            }
        }

        public void SendWarningMessage(Aircraft aircraft)
        {
            var list = from craft in this.registeredAircrafts
                       where craft != aircraft &&
                             Math.Abs(craft.Altitude - aircraft.Altitude) < 1000
                       select craft;
            foreach (var craft in list)
            {
                craft.ReceiveWarning(aircraft);
                aircraft.Climb(1000);
            }
        }
    }

public abstract class Aircraft
    {
        private readonly IAirTrafficControl atc;
        private int altitude;

        public Aircraft(string registrationNumber, IAirTrafficControl atc)
        {

            this.RegistrationNumber = registrationNumber;
            this.atc = atc;
            this.atc.RegistrerAircraft(this);
        }

        public string RegistrationNumber { get; set; }

        public int Altitude
        {
            get { return this.altitude; }
            set
            {
                this.altitude = value;
                this.atc.SendWarningMessage(this);
            }
        }

        public void Climb(int heightToClimb)
        {
            this.Altitude += heightToClimb;
        }

        public void ReceiveWarning(Aircraft reportingAircraft)
        {
            Console.WriteLine("ATC: ({0}) - {1} is at your flight altitude!!!",
              this.RegistrationNumber, reportingAircraft.RegistrationNumber);
        }
    }

public class Airbus380 : Aircraft
    {
        public Airbus380(string registrationNumber, IAirTrafficControl atc)
            : base(registrationNumber, atc)
        {
        }
    }

public class Boeing747 : Aircraft
    {
        public Boeing747(string registrationNumber, IAirTrafficControl atc)
            : base(registrationNumber, atc)
        {
        }
    }

```
##### Участници
ColleagueBase

ConcreteColleague

MediatorBase

ConcreateMediator

##### Структура

![](https://github.com/dchakov/High-Quality-Code-HomeWork/blob/master/17-Design%20Patterns/BehavioralPatterns/images/Mediator.jpg)

