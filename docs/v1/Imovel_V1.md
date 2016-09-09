# [**Voltar**](https://github.com/bguedesvieira/puc-asd-pds-oferta5-aula03/blob/master/README.md)

## ***Resource* Imóvel**

- Consulta de IPTU [Recebe o código cadastral do imóvel e devolve o imposto a ser pago] 

### **URL** /api/v1/imovel/valoriptu/{id}    **Verbo HTTP**: GET

#### Dados para testes:

   - new Realty {Id=1,
                TaxValue =1000,
                Place = new PublicPlace{ Id = 4, Type = "Rua", Name = "Sergipe", PostalCode = 30130170 } },
   - new Realty {Id=2,
                TaxValue =1200,
                Place = new PublicPlace{ Id = 3, Type = "Avenida", Name = "Afonso Pena", PostalCode = 30130000} },
   - new Realty {Id=3,
                TaxValue =300,
                Place = new PublicPlace{ Id = 1, Type = "Rua", Name = "Cláudio Manoel", PostalCode = 30140100} },
   - new Realty {Id=4,
                TaxValue =1500,
                Place = new PublicPlace{ Id = 2, Type = "Praça", Name = "da Liberdade", PostalCode = 30140010} },
    