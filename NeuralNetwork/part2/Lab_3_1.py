#Импорт необходимых библиотек
import numpy as np
import matplotlib.pyplot as plt

#=== функция расчета среднеквадратичной ошибки MSE
def Func_CalcMSE(var_fact, var_predict):
    res_temp = var_fact - var_predict # разница между прогнозируемыми и наблюдаемыми (факт.) значениями
    res_temp_squared = res_temp ** 2  # квадрат разницы (чтобы избавиться от отрицательных значений)
    res = res_temp_squared.mean()     # среднее значение

    return res

#=================================================Основная функция

#===Константы программы
x_beg = 0              # начало интервала
x_end = 10.1           # конец интервала
x_step = 0.1           # шаг изменения x
N = 14  # размер признакового пространства (степень полинома N-1)


x = np.arange(x_beg, x_end, x_step)                                      #значения x
y = np.array([a ** 4 - 10 * a ** 3 + 20 * a ** 2 - 100 * a for a in x])  # функция в виде полинома x^4 - 10x^3 + 20x^2 -100x
x_train, y_train = x[::2], y[::2]

min_y = round(min(y),1) - 0.1 # минимальное овещественное целое значение х1 в выборке (с запасом)
max_y = round(max(y),1) + 0.1 # максимальное овещественное целое значение х1 в выборке (с запасом)

X = np.array([[a ** n for n in range(N)] for a in x])  # матрица входных векторов

X_train = X[::2]  # обучающая выборка
Y = y_train  # обучающая выборка

# вычисление коэффициентов по формуле w = (XT*X + lambda*I)^-1 * XT * Y
A = np.linalg.inv(X_train.T @ X_train)
w = Y @ X_train @ A

y_predict = [np.dot(w, x) for x in X]

print('===========================Регрессия без L2-регуляризатором ')
print("Значения коэффициентов вектора w:")
print(w)
print("Значение среднеквадратической ошибки: MSE = %f" % (Func_CalcMSE(y, y_predict)))

#===Отрисовка графика целевой функции
plt.figure
plt.plot(x, y, color='blue', label = 'Целевая функция')

# Отрисовка прогноза
plt.plot(x, y_predict, 'r--', label = 'Прогнозная функция')

plt.xlim([x_beg, x_end])
plt.ylim([-max_y, max_y])
plt.ylabel("y")
plt.xlabel("x")
plt.title("Регрессия")
plt.legend()
plt.grid(True)
plt.show()