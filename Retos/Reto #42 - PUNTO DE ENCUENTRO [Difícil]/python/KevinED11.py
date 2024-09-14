from typing import NamedTuple, Protocol
import math
import functools


type Number = float | int


class Coordinates(NamedTuple):
    x: Number
    y: Number


class Velocity(Coordinates):
    pass


class Object(NamedTuple):
    start_point: Coordinates
    velocity: Velocity


class Objects(NamedTuple):
    object1: Object
    object2: Object


def calculate_diff_coordinates(
    obj1_coords: Coordinates, obj2_coords: Coordinates
) -> Coordinates:
    diff_x = obj2_coords.x - obj1_coords.x
    diff_y = obj2_coords.y - obj1_coords.y

    return Coordinates(x=diff_x, y=diff_y)


def calculate_diff_velocity(obj1_vel: Velocity, obj2_vel: Velocity) -> Velocity:
    diff_vel_x = obj2_vel.x - obj1_vel.x
    diff_vel_y = obj2_vel.y - obj1_vel.y

    return Velocity(x=diff_vel_x, y=diff_vel_y)


def calculate_time_to_intersection(
    diff_coordinates: Coordinates, diff_velocity: Velocity
) -> float:
    time_to_intersection = math.sqrt(
        diff_coordinates.x**2 + diff_coordinates.y**2
    ) / math.sqrt(diff_velocity.x**2 + diff_velocity.y**2)

    return time_to_intersection


def calculate_intersection_point(
    object1: Object, time_to_intersection: float
) -> Coordinates:
    intersection_x = object1.start_point.x + object1.velocity.x * time_to_intersection
    intersection_y = object1.start_point.y + object1.velocity.y * time_to_intersection

    return Coordinates(x=intersection_x, y=intersection_y)


def is_same_direction(diff_velocity: Velocity) -> bool:
    return diff_velocity.x == 0 and diff_velocity.y == 0


class Result(NamedTuple):
    time_to_intersection: float
    intersection_point: Coordinates


def calculate_intersection_point_in_motion(objects: Objects) -> Result:
    default_result = Result(
        time_to_intersection=0, intersection_point=Coordinates(x=0, y=0)
    )

    diff_coordinates: Coordinates = calculate_diff_coordinates(
        objects.object1.start_point, objects.object2.start_point
    )
    diff_velocity: Velocity = calculate_diff_velocity(
        objects.object1.velocity, objects.object2.velocity
    )

    if is_same_direction(diff_velocity=diff_velocity):
        return default_result

    time_to_intersection: float = calculate_time_to_intersection(
        diff_coordinates, diff_velocity
    )
    intersection_point: Coordinates = calculate_intersection_point(
        objects.object1, time_to_intersection
    )

    return Result(
        time_to_intersection=time_to_intersection, intersection_point=intersection_point
    )


class MotionCalculatorFn(Protocol):
    def __call__(self, objects: Objects) -> Result:
        ...


def execute(motion_calculator: MotionCalculatorFn, objects: Objects) -> Result:
    return motion_calculator(objects=objects)


def print_motion_calculator_results(result: Result) -> None:
    if result.time_to_intersection == 0:
        print("Los objetos o puntos de encuentro son paralelos y nunca se encuentran.")
        return
    
    print(
        f"El punto de encuentro es ({result.intersection_point.x}, {result.intersection_point.y})"
    )
    print(
        f"El tiempo que les tomará encontrarse es {result.time_to_intersection} segundos."
    )


def main() -> None:
    object1 = Object(start_point=Coordinates(x=2, y=2), velocity=Velocity(x=2, y=2))
    object2 = Object(start_point=Coordinates(x=2, y=2), velocity=Velocity(x=2, y=2))
    objects = Objects(object1=object1, object2=object2)

    execute_calculate_intersection_point_in_motion = functools.partial(
        execute, motion_calculator=calculate_intersection_point_in_motion
    )

    result1 = execute_calculate_intersection_point_in_motion(objects=objects)
    print_motion_calculator_results(result=result1)

    object3 = Object(start_point=Coordinates(x=4, y=3), velocity=Velocity(x=5, y=4))
    object4 = Object(start_point=Coordinates(x=4, y=1), velocity=Velocity(x=3, y=4))
    objects2 = Objects(object1=object3, object2=object4)

    result2 = execute_calculate_intersection_point_in_motion(objects=objects2)
    print_motion_calculator_results(result=result2)


if __name__ == "__main__":
    main()
