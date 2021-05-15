using System;
using System.collections.Generic;
using System.Linq;
using System.Text;

namespace Electrodomesticos
{
	public class Electrodomestico
	{
		public string nombre;
		public int codigo;
		public string marca;
		public float precio;
		public string tipo;
	}

	public class ParaSala:Electrodomestico
	{

	}

		public class Tv:ParaSala
		{
			public string definicion;//4k, 8k

			Tv cTv = new Tv(string pNombre, string pMarca, string pDefinicion)
			{
				nombre = pNombre;
				marca = pMarca;
				definicion = pDefinicion;
			}
		}

		public class Cables:ParaSala
		{
			//tipo HDMI, HDMG
			Cables cCables = new Cables (string pNombre, string pMarca, string pTipo)
			{
				nombre = pNombre;
				marca = pMarca;
				tipo = pTipo;
			}
		}

		public class Sonido:ParaSala
		{
			//tipo audifonos, equipo

			Sonido cSonido = new Sonido(string pNombre, string pMarca, string pTipo)
			{
				nombre = pNombre;
				marca = pMarca;
				tipo = ptipo;
			}
		}

		public class ControlRemoto:ParaSala
		{
			//Miray(CRM, LCDM) LG(Magic,Negro)
			ControlRemoto cControlRemoto = new ControlRemoto(string pNombre, string pMarca, string pTipo)
			{
				nombre = pNombre;
				marca = pMarca;
				tipo = pTipo;
			}
		}

		public class Ecran:ParaSala
		{
			//Xtreme,Zrem
			Ecran cEcran = new Ecran(string pNombre, string pMarca)
			{
				nombre = pNombre;
				marca = pMarca;
			}
		}

		public class Google:ParaSala
		{
			//tipo Mini Chromecast

			Google cGoogle = new Google(string pNombre, string pTipo)
			{
				nombre = pNombre;
				tipo = pTipo;
			}
		}

	public class ParaCocina:Electrodomestico
	{

	}
		public class Cocina:ParaCocina
		{
			Cocina cCocina = new Cocina (string pNombre, string pMarca)
			{
				nombre = pNombre;
				marca = pMarca;
			}
		}
		public class Liquidos:ParaCocina
		{
			Liquidos cLiquidos = new Liquidos (string pNombre, string pMarca)
			{
				nombre = pNombre;
				marca = pMarca;
			}
		}

	public class ParaConsola:Electrodomestico
	{

	}
		public class AccesorioConsola:ParaConsola
		{
			//tipo ps5, ps4, hyperX
			AccesorioConsola cAccesorioConsola = new AccesorioConsola (string pNombre, string pTipo)
			{
				nombre = pNombre;
				tipo = pTipo;
			}
		}

		public class Timones:ParaConsola
		{
			public string tipo = "Timon";
			//public string marca;//DrivingForces, G27

			Timones cTimones = new Timones(string pNombre, string pMarca,string pTipo){
				nombre = pNombre;
				marca = pMarca;
				tipo = pTipo;
			}
		}

		public class VideoJuegos:ParaConsola
		{
			public string tipo;// switch, ps4, vr
			public string saga;//mario, pokemon
			public string genero;//terror, accion, aventura

			VideoJuegos cVideoJuegos = new VideoJuegos(string nombre, string pTipo, string pSaga, string pGenero)
			{
				nombre = pNombre;
				tipo = pTipo;
				saga = pSaga;
				genero = pGenero;
			}
		}
}

public class Program()
{
	Tv tv1 = new Tv("TV Samsung QLED 4K Smart 85 QN85Q70TAGXPE", "Samsung", "4k");
	Tv tv2 = new Tv("TV Samsung QLED 4K UHD Smart 50 FQN50LS03T - 1", "Samsung", "4k"); 
	Tv tv3 = new Tv("TV Samsung QLED 8K Smart 85 QN85Q70TAGXPE", "Samsung", "8k");
	Tv tv4 = new Tv("TV Samsung QLED 8K UHD Smart 50 FQN50LS03T - 1", "Samsung", "8k");

	Cables cable1 = new Cables("Cable HDMI Miray CAHDMI - VC5", "Miray", "HDMI");
	Cables cable2 = new Cables("Cable HDMI Miray CAHDMI-VC3", "Miray", "HDMI")
	Cables cable3 = new Cables("Cable HDMG Miray CAHDMI-VC4", "Miray", "HDMG")
	Cables cable4 = new Cables("Cable HDMG Miray CAHDMI-VC7", "Miray", "HDMG")

	Sonido sonido1 = new Sonido("Soundbar Samsung HW-T450/PE", "Samsung", "Equipo");
	Sonido sonido2 = new Sonido("Torre de Sonido Samsung MX-T70", "Samsung", "Equipo");
	Sonido sonido1 = new Sonido("Audifonos Samsung MX-89", "Samsung", "Audifono");
	Sonido sonido2 = new Sonido("Audifonos Miray TX9", "Miray", "Audifono");

	ControlRemoto controlRemoto1 = new ControlRemoto("Control Remoto Miray CRM-188PA Compatible TV Panasonic", "Miray", "CRM");
	ControlRemoto controlRemoto2 = new ControlRemoto("Control Remoto Miray CRM-125SA Compatible TV Samsung", "Miray", "CRM");
	ControlRemoto controlRemoto3 = new ControlRemoto("Control Remoto Miray CRM-126SO Compatible TV Sony", "Miray", "CRM");
	ControlRemoto controlRemoto4 = new ControlRemoto("Control Remoto Miray CRM-5660LG Compatible tv LG", "Miray", "CRM");
	ControlRemoto controlRemoto5 = new ControlRemoto("Control Remoto Miray CRM-151", "Miray", "CRM");

	ControlRemoto controlRemoto6 = new ControlRemoto("Control Remoto Miray LCDM32-E14", "Miray", "LCDM");
	ControlRemoto controlRemoto7 = new ControlRemoto("Control Remoto Miray LCDM33-E17", "Miray", "LCDM");

	ControlRemoto controlRemoto8 = new ControlRemoto("Control remoto Magic LG MR20GA", "LG", "Magic");
	ControlRemoto controlRemoto9 = new ControlRemoto("Control remoto Magic LG MR30GB", "LG", "Magic");

	ControlRemoto controlRemoto10 = new ControlRemoto("Control remoto Negro LG", "LG", "Negro");
	ControlRemoto controlRemoto11 = new ControlRemoto("Control remoto Negro LG MR32CI", "LG", "Negro");

	Ecran ecran1 = new Ecran("Ecran de Pared Klip Xtreme KPS - 301 / B / W", "Xtreme");
	Ecran ecran2 = new Ecran("Ecran de Pared Klip Xtreme KPS-380W", "Xtreme");
	Ecran ecran3 = new Ecran("Ecran de Pared Klip Zrem KPS-300W", "Zrem");
	Ecran ecran4 = new Ecran("Ecran de Pared Klip Zrem KPS-350W", "Zrem");

	Google google1 = new Google("Google Home Mini Negro", "Mini");
	Google google2 = new Google("Google Home Mini Blanco", "Mini");
	Google google3 = new Google("Google Chromecast 3 GA00439-US", "Chromecast");
	Google google4 = new Google("Google Chromecast 5 GA00450-US", "Chromecast");

	Cocina cocina1 = new Cocina("Máquina de Pop-corn","");
	Cocina cocina2 = new Cocina("Máquina de Nachos","");
	Cocina cocina3 = new Cocina("Cafetera Miray CM-838","Miray");
	Cocina cocina4 = new Cocina("Máquina conservadora de Agua Miray","Miray");

	AccesorioConsola accesorioConsola1 = new AccesorioConsola("Consola PS4 Slim 1TB Sony Mega Pack 15", "PS4");
	AccesorioConsola accesorioConsola2 = new AccesorioConsola("Consola PS4 Slim 1TB Sony FIFA 21", "PS4");
	AccesorioConsola accesorioConsola3 = new AccesorioConsola("Visor PS4 PSVR Sony Value Pack", "PS4");

	AccesorioConsola accesorioConsola4 = new AccesorioConsola("Auricular Pulse PS5 Sony", "PS5");
	AccesorioConsola accesorioConsola5 = new AccesorioConsola("Cámara para PS5 Sony", "PS5");

	AccesorioConsola accesorioConsola6 = new AccesorioConsola("Cargador Hyperx PLAY DUO HX-CPDU-A", "Hyperx");
	AccesorioConsola accesorioConsola7 = new AccesorioConsola("Cargador Hyperx 2 PLAY DUO HX-CPZU-B", "Hyperx");

	Timones timones1 = new Timones("Timón Logitech G27", "Logitech", "G27");
	Timones timones2 = new Timones("Timón Logitech G27 ZB", "Logitech", "G27");
	Timones timones3 = new Timones("Timón Logitech G29 Driving Force", "Logitech", "Driving Forces");
	Timones timones4 = new Timones("Timón Logitech G40 Driving Force", "Logitech", "Driving Forces");

	VideoJuegos videoJuegos1 = new VideoJuegos("Super Smash Bros Ultimate Switch Nintendo", "Switch", "Saga Mario", "");
	VideoJuegos videoJuegos2 = new VideoJuegos("Super Mario Odyssey Switch Nintendo", "Switch", "Saga Mario", "");
	VideoJuegos videoJuegos3 = new VideoJuegos("Super Mario Maker 2 Switch Nintendo", "Switch", "Saga Mario", "");
	VideoJuegos videoJuegos4 = new VideoJuegos("Luigis Mansion 3 Switch Nintendo", "Switch", "Saga Mario", "");
	VideoJuegos videoJuegos5 = new VideoJuegos("Mario Kart 8 Deluxe Switch Nintendo", "Switch", "Saga Mario", "");

	VideoJuegos videoJuegos6 = new VideoJuegos("Pokemon Sword Switch Nintendo", "Switch", "Saga Pokemon", "");
	VideoJuegos videoJuegos7 = new VideoJuegos("Go Eevee+Pokeball Switch Nintendo", "Switch", "Saga Pokemon", "");

	VideoJuegos videoJuegos8 = new VideoJuegos("Call of Duty Black Ops Cold War PS4", "PS4", "", "Acción");
	VideoJuegos videoJuegos9 = new VideoJuegos("Sony Fifa 21 PS4", "PS4", "", "Acción");
	VideoJuegos videoJuegos10 = new VideoJuegos("Spider Man Miles Morales PS4", "PS4", "", "Acción");
	VideoJuegos videoJuegos11 = new VideoJuegos("E-football PES 2021 PS4", "PS4", "", "Acción");
	VideoJuegos videoJuegos12 = new VideoJuegos("Injustice 2 Legendary PS4", "PS4", "", "Acción");
	VideoJuegos videoJuegos13 = new VideoJuegos("Asassins Creed 4 Black PS4", "PS4", "", "Acción");
	VideoJuegos videoJuegos14 = new VideoJuegos("Tony Hawk's Pro Skater 1+2 PS4", "PS4", "", "Acción");
	VideoJuegos videoJuegos15 = new VideoJuegos("Captain Tsubasa Rise of New Champions PS4", "PS4", "", "Acción");
	VideoJuegos videoJuegos16 = new VideoJuegos("Crash Racing Bandicott Bundle PS4", "PS4", "", "Acción");

	VideoJuegos videoJuegos17 = new VideoJuegos("Sackboy: A Big Adventure PS4", "PS4", "", "Aventura");
	VideoJuegos videoJuegos18 = new VideoJuegos("Crash Bandicoot 4 It's about time PS4", "PS4", "", "Aventura");
	VideoJuegos videoJuegos19 = new VideoJuegos("Ghost of Tsushima PS4", "PS4", "", "Aventura");
	VideoJuegos videoJuegos20 = new VideoJuegos("EVE: Valkyrie PS4 Sony", "PS4", "", "Aventura");
	VideoJuegos videoJuegos21 = new VideoJuegos("Apex Legends B.H.E. PS4", "PS4", "", "Aventura");
	VideoJuegos videoJuegos22 = new VideoJuegos("Crash B N Trilogy PS4", "PS4", "", "Aventura");

	VideoJuegos videoJuegos23 = new VideoJuegos("Skyrim VR Sony", "VR", "", "Aventura");
	VideoJuegos videoJuegos24 = new VideoJuegos("Legends of Zelda VR Sony", "VR", "", "Aventura");
	VideoJuegos videoJuegos25 = new VideoJuegos("Five Nights at Freddy's VR: Help Wanted", "VR", "", "Terror");
	VideoJuegos videoJuegos26 = new VideoJuegos("Omori More Terror Pack VR", "VR", "", "Terror");
}