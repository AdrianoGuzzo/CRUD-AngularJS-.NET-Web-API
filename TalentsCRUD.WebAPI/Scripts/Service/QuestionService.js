app.service('question', function () {
    this.Questions = function () {
        return {
            QuestionWillingness : {
                Question: "What is your willingness to work today? / Qual é sua disponibilidade para trabalhar hoje?",
                prop: 'QuestionWillingness',
                required: true,
                answers: [
                    { id: 1, answer: "Up to 4 hours per day / Até 4 horas por dia" },
                    { id: 2, answer: "4 to 6 hours per day / De 4 á 6 horas por dia" },
                    { id: 3, answer: "6 to 8 hours per day /De 6 á 8 horas por dia" },
                    { id: 4, answer: "Up to 8 hours a day (are you sure?) / Acima de 8 horas por dia (tem certeza?)" },
                    { id: 5, answer: "Only weekends / Apenas finais de semana" },
                ]
            },
            QuestionBestTime: {
                Question: "What's the best time to work for you? / Pra você qual é o melhor horário para trabalhar?",
                prop: 'QuestionBestTime',
                required: true,
                answers: [
                    { id: 1, answer: "Morning (from 08:00 to 12:00) / Manhã (de 08:00 ás 12:00)" },
                    { id: 2, answer: "Afternoon (from 1:00 p.m. to 6:00 p.m.) / Tarde (de 13:00 ás 18:00)" },
                    { id: 3, answer: "Night (7:00 p.m. to 10:00 p.m.) /Noite (de 19:00 as 22:00)" },
                    { id: 4, answer: "Dawn (from 10 p.m. onwards) / Madrugada (de 22:00 em diante)" },
                    { id: 5, answer: "Business (from 08:00 a.m. to 06:00 p.m.) / Comercial (de 08:00 as 18:00)" },
                ]
            }
        };
    }
});