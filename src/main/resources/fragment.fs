#version 330

out vec4 fragColor;

uniform vec4 ourColor;

void main() {
    fragColor = ourColor;
}