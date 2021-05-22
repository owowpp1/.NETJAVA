package MieszkanieCalc;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;

public class SQLite {
	
	public DateFormat data_format = new SimpleDateFormat("dd.MM.yyyy");

	Connection c=null;
	Statement st=null;
	
	SQLite(){		//konstruktor- ³¹czy siê z baz¹ danych lub tworzy ja jesli nie istnieje
		String sql = "CREATE TABLE IF NOT EXISTS najemcy (\n"
                + "	id integer PRIMARY KEY,\n"
                + "	Imie text,\n"
                + "	wynajem_od text,\n"
                + "	wynajem_do text,\n"
                + "	bilans REAL"
                + ");";
		try{
			Class.forName("org.sqlite.JDBC");
			c=DriverManager.getConnection("jdbc:sqlite:Najemcy.sqlite");
			st=c.createStatement();
			st.executeUpdate(sql);
			System.out.println("Po³¹czono z baz¹ danych");
		} catch(Exception e){
			System.out.println("B³¹d wczytaj: "+e.getMessage());
		}
	}
	
	public String Wypisz(){	//wypisanie zawartoœci bazy danych do konsoli
		String output="";
		try{
			this.st=c.createStatement();
			ResultSet wynik = st.executeQuery("SELECT * FROM najemcy");
			while(wynik.next()){
				int id=wynik.getInt("id");
				String imie=wynik.getString("Imie");
				Date wynajem_od=data_format.parse(wynik.getString("wynajem_od"));
				Date wynajem_do=data_format.parse(wynik.getString("wynajem_do"));
				Double bilans=wynik.getDouble("bilans");
				
				System.out.println(id+"    "+imie+" "+data_format.format(wynajem_od)+" "+data_format.format(wynajem_do)+" "+bilans);
				output+=(id+"    "+imie+" "+data_format.format(wynajem_od)+" "+data_format.format(wynajem_do)+" "+bilans+"\n");
			}
		} catch (Exception e){
			System.out.println("B³¹d wypisz: "+e.getMessage());
		}
		return output;
	}
	
	public void zamnijBD(){		//zamkniêcie po³¹czenia z baz¹ danych
		try{
			c.close();
		} catch (Exception e){
			System.out.println("B³¹d zamknij: "+e.getMessage());
		}
	}
	
	public void Zapytanie(String kwerenda){		//wykonanie kwerendy SQL
		String check="";
		if(kwerenda.length()>6){
			check=kwerenda.substring(0,6);
		}
		if(check.equals("DELETE")||check.equals("INSERT")||check.equals("UPDATE")){
			try{
				this.st=c.createStatement();
				st.executeUpdate(kwerenda);
			} catch (Exception e){
				System.out.println("B³¹d zapytanie: "+e.getMessage());
			}
		}
		else{
			try{
				this.st=c.createStatement();
				st.executeQuery(kwerenda);
			} catch (Exception e){
				System.out.println("B³¹d zapytanie: "+e.getMessage());
			}
		}
	}
}
