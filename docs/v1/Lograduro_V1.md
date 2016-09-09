# [**Voltar**](https://github.com/bguedesvieira/puc-asd-pds-oferta5-aula03/blob/master/README.md)

## ***Resource* Logradouro**
 
- Consulta de Coleta de Lixo [Recebe o logradouro.]

### **URL** /api/v1/logradouros/coletalixo/{id} **Verbo HTTP:** GET

#### Dados para teste:

 - { Id = 1, Type = "Rua", Name = "Cláudio Manoel", PostalCode = 30140100,GarbageCollection ="SEGUNDA;QUARTA"},
 - { Id = 2, Type = "Praça", Name = "da Liberdade", PostalCode = 30140010,GarbageCollection="TERÇA;QUINTA;SABADO"},
 - { Id = 3, Type = "Avenida", Name = "Afonso Pena", PostalCode = 30130000,GarbageCollection="TODOS OS DIAS"},
 - { Id = 4, Type = "Rua", Name = "Sergipe", PostalCode = 30130170, GarbageCollection="SEGUNDA;QUARTA;SEXTA;SABADO" }