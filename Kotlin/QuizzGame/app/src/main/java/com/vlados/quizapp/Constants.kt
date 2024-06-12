package com.vlados.quizapp

import com.vlados.quizapp.R

object Constants {

    const val USER_NAME: String = "User_name"
    const val TOTAL_QUESTIONS: String = "total_question"
    const val CORRECT_ANSWERS: String = "correct_answers"

    fun getQuestions(): ArrayList<Question> {
        val questionsList = ArrayList<Question>()

        // 1
        val que1 = Question(
            1, "Флаг какой страны изображен на рисунке?",
            R.drawable.ic_flag_of_argentina, "Аргентина", "Австралия", "Армения",
            "Австрия", 1
        )

        questionsList.add(que1)

        // 2
        val que2 = Question(
            2, "Флаг какой страны изображен на рисунке?",
            R.drawable.ic_flag_of_australia,
            "Ангола", "Австрия",
            "Австралия", "Армения", 3
        )

        questionsList.add(que2)

        // 3
        val que3 = Question(
            3, "Флаг какой страны изображен на рисунке?",
            R.drawable.ic_flag_of_brazil,
            "Беларусь", "Белиз",
            "Бруней", "Бразилия", 4
        )

        questionsList.add(que3)

        // 4
        val que4 = Question(
            4, "Флаг какой страны изображен на рисунке?",
            R.drawable.ic_flag_of_belgium,
            "Багамские острова", "Бельгия",
            "Барбадос", "Белиз", 2
        )

        questionsList.add(que4)

        // 5
        val que5 = Question(
            5, "Флаг какой страны изображен на рисунке?",
            R.drawable.ic_flag_of_fiji,
            "Габон", "Франция",
            "Фиджи", "Финляндия", 3
        )

        questionsList.add(que5)

        // 6
        val que6 = Question(
            6, "Флаг какой страны изображен на рисунке?",
            R.drawable.ic_flag_of_germany,
            "Германия", "Грузия",
            "Греция", "Ни одно из этих", 1
        )

        questionsList.add(que6)

        // 7
        val que7 = Question(
            7, "Флаг какой страны изображен на рисунке?",
            R.drawable.ic_flag_of_denmark,
            "Доминика", "Египет",
            "Дания", "Эфиопия", 3
        )

        questionsList.add(que7)

        // 8
        val que8 = Question(
            8, "Флаг какой страны изображен на рисунке?",
            R.drawable.ic_flag_of_india,
            "Ирландия", "Иран",
            "Венгрия", "Индия", 4
        )

        questionsList.add(que8)

        // 9
        val que9 = Question(
            9, "Флаг какой страны изображен на рисунке?",
            R.drawable.ic_flag_of_new_zealand,
            "Австралия", "Новая Зеландия",
            "Тувалу", "США", 2
        )

        questionsList.add(que9)

        // 10
        val que10 = Question(
            10, "Флаг какой страны изображен на рисунке?",
            R.drawable.ic_flag_of_kuwait,
            "Кувейт", "Иордания",
            "Судан", "Палестина", 1
        )

        questionsList.add(que10)
        return questionsList
    }
}