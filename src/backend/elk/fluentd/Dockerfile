# fluentd/Dockerfile

FROM fluent/fluentd:v1.17-debian
USER root
RUN ["gem", "install", "fluent-plugin-elasticsearch", "--no-document", "--version", "4.3.3"]
USER fluent