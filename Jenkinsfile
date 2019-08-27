pipeline {
  agent {
    docker {
      image 'alpine'
    }

  }
  stages {
    stage('Welcome') {
      steps {
        echo 'Hello World'
        sleep 10
      }
    }
    stage('Email') {
      steps {
        mail(subject: 'The subject', body: 'the body', from: 'bmhoang@tma.com.vn', replyTo: 'bmhoang@tma.com.vn', to: 'bmhoang@tma.com.vn')
      }
    }
    stage('End') {
      steps {
        echo 'End'
        sleep 10
      }
    }
  }
}