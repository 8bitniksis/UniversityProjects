import numpy as np
import matplotlib.pyplot as plt
from sklearn import svm


# обучающая выборка с тремя признаками (третий - константа +1)
data_x = [[3.0, 1.3], [3.4, 1.6], [3.4, 0.4], [3.7, 0.2], [3.5, 0.2], [3.4, 0.2], [3.4, 0.4], [3.9, 0.4], [3.4, 0.3],
          [3.2, 0.2], [2.8, 1.3], [3.5, 0.3], [2.4, 1.0], [3.0, 0.1], [3.6, 0.2], [3.2, 0.2], [2.9, 0.2], [2.9, 1.3],
          [2.3, 1.3], [3.8, 0.2], [3.2, 1.5], [2.3, 1.0], [3.0, 1.7], [3.3, 0.2], [3.4, 0.2], [3.8, 0.3], [2.0, 1.0],
          [3.1, 0.2], [2.5, 1.3], [2.4, 1.1], [3.2, 0.2], [2.2, 1.0], [3.1, 1.4], [3.0, 0.2], [3.0, 0.2], [3.4, 0.2],
          [3.7, 0.2], [2.8, 1.2], [2.9, 1.4], [4.0, 0.2], [3.2, 1.4], [3.2, 0.2], [2.9, 1.3], [2.9, 1.3], [3.5, 0.2],
          [3.3, 1.6], [2.9, 1.3], [2.7, 1.0], [2.9, 1.3], [3.4, 0.2], [3.2, 0.2], [4.1, 0.1], [3.5, 0.6], [2.7, 1.4],
          [2.3, 0.3], [2.9, 1.5], [3.1, 1.5], [3.5, 0.2], [2.7, 1.6], [3.3, 0.5], [3.0, 1.4], [3.6, 0.2], [3.0, 1.2],
          [2.8, 1.3], [2.5, 1.1], [3.0, 1.5], [3.1, 0.2], [2.6, 1.0], [2.7, 1.2], [2.2, 1.5], [3.7, 0.4], [3.4, 0.2],
          [3.5, 0.3], [3.6, 0.1], [2.5, 1.5], [2.6, 1.2], [2.8, 1.3], [3.1, 0.1], [2.4, 1.0], [3.1, 1.5], [2.3, 1.3],
          [2.8, 1.5], [3.0, 0.3], [3.0, 0.2], [2.5, 1.1], [3.0, 1.5], [3.2, 1.8], [3.9, 0.4], [2.8, 1.4], [4.2, 0.2],
          [3.4, 0.2], [2.7, 1.3], [3.8, 0.3], [3.0, 1.4], [2.6, 1.2], [4.4, 0.4], [3.8, 0.4], [3.1, 0.2], [3.0, 0.1],
          [3.0, 1.5]]
data_y = [1, 1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, -1, 1, 1, 1, -1, -1, -1, 1, -1, 1, 1,
          -1, 1, 1, -1, -1, -1, -1, 1, 1, -1, 1, -1, 1, 1, -1, 1, 1, 1, 1, -1, -1, -1, -1, 1, -1, 1, 1, -1, 1, -1, 1,
          -1, 1, 1, 1, 1, -1, 1, 1, 1, -1, -1, -1, -1, 1, 1, 1, -1, 1, 1, 1, 1, -1, -1, 1, 1, 1, -1, 1, -1, -1, 1, -1,
          1, 1, -1, -1, -1, -1, 1]

data_x = [x + [1] for x in data_x]
x_train = np.array(data_x)            # обучающая выборка по x
y_train = np.array(data_y)            # обучающая выборка по y

n_dot=len(y_train)                    # общее число точек
n_dot_class1 = 0                      # число точек, принадлежащих классу 1
n_dot_class2 = 0                      # число точек, принадлежащих классу 2
# определение количества точек, принадлежащих к каждому классу
for i in range(n_dot):
    if y_train[i] == 1:
        n_dot_class1 +=1
    else:
        n_dot_class2 +=1


clf = svm.SVC(kernel='linear')      # SVM с линейным ядром
clf.fit(x_train, y_train)           # вычисление вектора w по обучающей выборке
y_pr = clf.predict(x_train)         # проверка на обучающей выборке
y_res = np.array(y_train) - np.array(y_pr) # нули - без ошибок; иначе - ошибка

n_err = 0                           # количество ошибок классификации
for i in range(n_dot):
    if y_res[i] != 0:
        n_err +=1
n_err_perc = (n_err/n_dot)*100     # количество ошибок классификации в процентах

lin_clf = svm.LinearSVC()           # SVM для линейно разделимой выборки (используется для получения вектора w)
lin_clf.fit(x_train, y_train)       # нахождение вектора w по обучающей выборке

v = clf.support_vectors_            # выделение опорных векторов
w = lin_clf.coef_[0]                # коэффициенты линейной модели
print('===========================Метод опорных векторов SVM ')

print("Общее количество точек n = %d" % (n_dot))
print("Количество точек, относящихся к классу 1 = %d" % (n_dot_class1))
print("Количество точек, относящихся к классу 2 = %d" % (n_dot_class2))
print("Число неверных классификаций n_err = %d" % (n_err))
print("Процент неверных классификаций n_err_perc = %f" % (n_err_perc))


print('Полученные коэффициенты линейной модели w:')
print(w)
print('Полученные опорные векторы v:')
print(v)


# формирование графиков для визуализации полученных результатов
x_train = np.array(x_train)
y_train = np.array(y_train)
max_x1_int = round(max(x_train[:, 0])) + 2 # максимальное округленное целое значение х1 в выборке (с запасом)
max_x1_float = round(max(x_train[:, 0]),1) + 0.1 # максимальное овещественное целое значение х1 в выборке (с запасом)
max_x2_float = round(max(x_train[:, 1]),1) + 0.1 # максимальное овещественное целое значение х2 в выборке (с запасом)
line_x = list(range(max_x1_int))    # формирование графика разделяющей линии
line_y = [-x*w[0]/w[1] - w[2] for x in line_x]

x_0 = x_train[y_train == 1]                 # формирование точек для 1-го
x_1 = x_train[y_train == -1]                # и 2-го классов

#===отрисовка графика
#plt.scatter(x_0[:, 0], x_0[:, 1], color='red')
plt.scatter(x_0[:, 0], x_0[:, 1], marker = '^', color='red', label = 'Класс 1')
plt.scatter(x_1[:, 0], x_1[:, 1], color='blue', label = 'Класс 2')
plt.scatter(v[:, 0], v[:, 1], s=70, edgecolor=None, linewidths=0, marker='s', label = 'Опорный вектор')
plt.plot(line_x, line_y, color='green', label = 'Разделяющая линия')

plt.xlim([0, max_x1_float])
plt.ylim([0, max_x2_float])
plt.ylabel("x2")
plt.xlabel("x1")
plt.title("Результаты метода опорных векторов SVM")
plt.legend()
plt.grid(True)
plt.show()