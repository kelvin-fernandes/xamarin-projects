using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ConsumingApi.Api;
using ConsumingApi.Model;
using Xamarin.Forms;

namespace ConsumingApi.ViewModel {
    public class PesquisaVM : ViewModelBase {
        private string _local;

        public string Local {
            get => _local;
            set {
                _local = value;
                Notify("Local");
            }
        }

        private string _nome;

        public string Nome {
            get => _nome;
            set {
                _nome = value;
                Notify("Nome");
            }
        }

        private int _nuvens;

        public int Nuvens {
            get => _nuvens;
            set {
                _nuvens = value;
                Notify("Nuvens");
            }
        }

        private double _latitude;

        public double Latitude {
            get => _latitude;
            set {
                _latitude = value;
                Notify("Latitude");
            }
        }

        private double _longitude;

        public double Longitude {
            get => _longitude;
            set {
                _longitude = value;
                Notify("Longitude");
            }
        }

        private double _temperatura;

        public double Temperatura {
            get => _temperatura;
            set {
                _temperatura = value;
                Notify("Temperatura");
            }
        }

        private double _humidade;

        public double Humidade {
            get => _humidade;
            set {
                _humidade = value;
                Notify("Humidade");
            }
        }

        private double _tempMinima;

        public double TempMinima {
            get => _tempMinima;
            set {
                _tempMinima = value;
                Notify("TempMinima");
            }
        }

        private double _tempMaxima;

        public double TempMaxima {
            get => _tempMaxima;
            set {
                _tempMaxima = value;
                Notify("TempMaxima");
            }
        }

        private string _pais;

        public string Pais {
            get => _pais;
            set {
                _pais = value;
                Notify("Pais");
            }
        }

        private double _velocidade;

        public double Velocidade {
            get => _velocidade;
            set {
                _velocidade = value;
                Notify("Velocidade");
            }
        }

        public ICommand BuscarCommand { get; set; }

        public PesquisaVM() {
            BuscarCommand = new Command(BuscarCidadeAction);
        }

        public async void BuscarCidadeAction() {
            RootObject rootObject = await ApiTemperatura.GetAsync(Local);
            SetProperties(rootObject);
        }

        public void SetProperties(RootObject rootObject) {
            Nome = rootObject.name;
            Nuvens = rootObject.clouds.all;
            Latitude = rootObject.coord.lat;
            Longitude = rootObject.coord.lon;
            Temperatura = rootObject.main.temp;
            Humidade = rootObject.main.humidity;
            TempMaxima = rootObject.main.temp_max;
            TempMinima = rootObject.main.temp_min;
            Pais = rootObject.sys.country;
            Velocidade = rootObject.wind.speed;
        }
    }
}
