using exemplos.models;

Pessoa p1 = new Pessoa("Artulanez","Souza",32);
Pessoa p2 = new Pessoa("Lucrecia","Cariolano",34);

Curso cursoDeIngles = new Curso("Ingles");

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

