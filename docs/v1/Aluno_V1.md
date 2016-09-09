# [**Voltar**](https://github.com/bguedesvieira/puc-asd-pds-oferta5-aula03/blob/master/README.md)

## ***Resource* Aluno**

### Consulta de Histórico de Aluno de Rede Pública [Recebe o código do aluno e devolve o histórico do mesmo.]

#### **URL**: /api/v1/alunos/historico/{id} **Verbo HTTP**: GET
#### Dados para Teste:
   -  new Student {Id = 1,Name = "Joãozinho" ,
            Subjects = new SubjectStudent[]  { new SubjectStudent { Subject = new Subject { Id = 1, Name = "Matemática" },Grade = 7 },
                                               new SubjectStudent { Subject = new Subject { Id = 2, Name = "Português"}, Grade = 7 },
                                               new SubjectStudent {Subject = new Subject { Id = 3, Name = "Inglês" }, Grade = 8 }
                                             }
            },
  -  new Student {Id = 2,Name = "Maria" ,
            Subjects = new SubjectStudent[]  { new SubjectStudent { Subject = new Subject { Id = 1, Name = "Matemática" },Grade = 9 },
                                               new SubjectStudent { Subject = new Subject { Id = 2, Name = "Português"}, Grade = 8 },
                                               new SubjectStudent {Subject = new Subject { Id = 4, Name = "Espanhol" }, Grade = 10 }
                                             }
            }

