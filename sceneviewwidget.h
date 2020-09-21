#ifndef SCENEVIEWWIDGET_H
#define SCENEVIEWWIDGET_H

#include <QWidget>
#include <QOpenGLWidget>
#include <GL/glu.h>
#include <GL/gl.h>

class SceneViewWidget : public QOpenGLWidget
{
public:
    SceneViewWidget(QWidget *parent = 0);
    ~SceneViewWidget();

protected:
    void initializeGL();
    void resizeGL(int width, int height);
    void paintGL();
};

#endif // SCENEVIEWWIDGET_H
