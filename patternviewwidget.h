#ifndef PATTERNVIEWWIDGET_H
#define PATTERNVIEWWIDGET_H

#include <QOpenGLWidget>
#include <QWidget>
#include <GL/glu.h>
#include <GL/gl.h>

class PatternViewWidget : public QOpenGLWidget
{
public:
    PatternViewWidget(QWidget *parent = 0);
    ~PatternViewWidget();

protected:
    void initializeGL();
    void resizeGL(int width, int height);
    void paintGL();
};

#endif // PATTERNVIEWWIDGET_H
