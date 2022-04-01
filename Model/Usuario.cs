using System.Data.SqlClient;

namespace Model;
public class Usuario
{
    private string login;
    private string password;

    public Usuario(string login, string password)
    {  
        this.login = login;
        this.password = password;
    }

    public string GetLogin()
    {
        return this.login;
    }

    public void SetLogin(string login)
    {
        this.login=login;
    }

    public string GetPassword()
    {
        return this.password;
    }

    public void SetPassword(string password)
    {
        this.password=password;
    }

    public int search(string login)
    {
        Connect con = new Connect();

        con.createConnect();
        SqlCommand command = new SqlCommand("Select id from Usuario Where login = " + login, con.connection);

        return 0;
    }


}
