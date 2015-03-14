# Abstract #
The traveling salesman problem (TSP) is a well-known NP-complete problem. It has appeared in diverse field of human knowledge. Different heuristics have been developed to generate approximate solutions for TSP. In this project, we are using 3 different heuristics for TSP to implement a half toning algorithm.

# Approach #
In this project, we have taken the following steps to implement a half toning algorithm.
Given any input image,

  * If the image is a color image, convert it into a black & white image.

  * Now we generate the “cities”/vertices of a complete graph on which TSP algorithm will be applied. We distribute cities with a density that locally approximates the darkness of a source image.

  * Now we run nearest neighbor, greedy and 2-opt heuristics for TSP on the “cities”. This produces a single closed path that resembles the original image.