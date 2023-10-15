#===Импорт необходимых библиотек
import numpy as np
import tensorflow as tf
import keras
from keras.models import Sequential
from keras.layers import Conv2D,MaxPooling2D,Dense,Flatten,Dropout
import matplotlib.pyplot as plt
from keras.layers.normalization import BatchNormalization
from keras_preprocessing import image
from tensorflow.keras.preprocessing.image import ImageDataGenerator

#===Загрузка данных и разделение на выборки
dataset_dir="../input/face-recognition-dataset/Original Images/Original Images/"
generator = ImageDataGenerator()
pics = generator.flow_from_directory(dataset_dir,target_size=(256, 256),batch_size=32)
classes = list(pics.class_indices.keys())
print(classes)

#===================Формирование модели и сети CNN
model = Sequential()
model.add(Conv2D(32, kernel_size = (3, 3), activation='relu', input_shape=(256,256,3)))
model.add(MaxPooling2D(pool_size=(2,2)))
model.add(BatchNormalization())
model.add(Conv2D(64, kernel_size=(3,3), activation='relu'))
model.add(MaxPooling2D(pool_size=(2,2)))
model.add(BatchNormalization())
model.add(Conv2D(64, kernel_size=(3,3), activation='relu'))
model.add(MaxPooling2D(pool_size=(2,2)))
model.add(BatchNormalization())
model.add(Conv2D(96, kernel_size=(3,3), activation='relu'))
model.add(MaxPooling2D(pool_size=(2,2)))
model.add(BatchNormalization())
model.add(Conv2D(32, kernel_size=(3,3), activation='relu'))
model.add(MaxPooling2D(pool_size=(2,2)))
model.add(BatchNormalization())
model.add(Dropout(0.2))
model.add(Flatten())
model.add(Dense(128, activation='relu'))
#model.add(Dropout(0.3))
model.add(Dense(len(classes),activation='softmax'))

#===Компиляция нейронной сети CNN
model.compile(
    loss = 'categorical_crossentropy',
    optimizer = 'adam',
    metrics = ["accuracy"])
model.summary()

#===Отрисовка статистики обучения по эпохам
plt.plot(history.history['accuracy'])
plt.plot(history.history['loss'])
plt.xlabel('Время')
plt.legend(['Точность', 'Потери'])
plt.show()

def predict_image(image_path):
    img = image.load_img(image_path, target_size=(256,256,3))
    plt.imshow(img)
    plt.show()
    x = image.img_to_array(img)
    x = np.expand_dims(x, axis=0)
    images = np.vstack([x])
    pred = model.predict(images, batch_size=32)
    print("Фактический класс: "+(image_path.split("/")[-1]).split("_")[0])
    print("Прогнозный класс: "+classes[np.argmax(pred)])

predict_image("../input/face-recognition-dataset/Original Images/Original Images/Charlize Theron/Charlize Theron_77.jpg")