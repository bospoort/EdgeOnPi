FROM alpine:3.1

# Update
#RUN apk add --update python py-pip

# Bundle app source
COPY hello.py /hello.py

EXPOSE  8000
CMD ["python", "/hello.py", "-p 8000"]