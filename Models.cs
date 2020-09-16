class Dispesa{

  private string nome;
  private string tag;
  private string pagamento;
  private double valor;
  
  public string Nome{
    get{ return nome; }
    set{ nome = value; }
  }

  public string Tag{
    get{ return tag; }
    set{ tag = value; }
  }

  public string Pagamento{
    get{ return pagamento; }
    set { pagamento = value; }
  }

  public double Valor{
    get{ return valor; }
    set{ valor = value; }
  }

  public void CadastrarDispesa( Dispesa obj ){
    
  }

}

class Tag{

  private int idTag;  
  private string nomeTag;

  public int IdTag{
    get{ return idTag; }
    set{ idTag = value; }
  }

  public string NomeTag{
    get{ return nomeTag; }
    set{ nomeTag = value; }
  }

  public void CadastraTag(){

  }

  public void ListaTags(){

  }

}

class Pagamento{

  private int idPag;
  private string tipoPag;

  public int IdPag{
    get{ return idPag; }
    set{ idPag = value; }
  }

  public string TipoPag{
    get{ return tipoPag; }
    set{ tipoPag = value; }
  }

  public void CadastraTag(){

  }

  public void ListaTags(){

  }

}

class Relatorio{
  // Classe dos Relatorios

}