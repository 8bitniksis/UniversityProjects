
#Импорт необходимых библиотек
import numpy as np
import tensorflow as tf
from tensorflow import keras

a = -50
b = 50
x1 = np.random.randint(-50, 50, size=50)
x2 = np.random.randint(-50, 50, size=50)
x3 = np.random.randint(-50, 50, size=50)

X = np.vstack([x1, x2, x3]).T
X

y = x1 - x2 - x3 + 4
y = y[None]
y = y.T
y

model = keras.Sequential()

model.add(Dense(units=1, input_shape=(3,), activation='linear'))

model.compile(loss='mean_squared_error', optimizer=keras.optimizers.Adam(0.1))

model.compile(optimizer='sgd', loss='mse', metrics='mae')

log = model.fit(X, y, epochs=500, verbose=False)

plt.plot(log.history['loss'])
plt.grid(True)
plt.show()

print(model.predict([[18, -2, 10]]))

print(model.get_weights())