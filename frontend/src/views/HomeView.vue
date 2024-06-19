<template>
  <div class="min-h-full">
    <BaseNavbar />
    <header class="bg-white shadow-sm">
      <div class="mx-auto max-w-7xl px-4 py-4 sm:px-6 lg:px-8">
        <h1 class="text-lg font-semibold leading-6 text-gray-900">Entertainment Center</h1>
      </div>
    </header>
    <main>
      <div class="mx-auto max-w-7xl py-6 sm:px-6 lg:px-8">
        <div class="container mx-auto p-4">
          <h2 class="text-2xl font-semibold mb-4 text-center">Welcome to our entertainment center!</h2>
          <p class="text-gray-700 mb-8 text-center">Explore our facilities, areas, and events.</p>

          <!-- Facilities Section -->
          <section class="mb-8 bg-gray-100 p-4 rounded-lg shadow-md">
            <h3 class="text-xl font-semibold mb-4 text-center">Facilities</h3>
            <Carousel :items-to-show="3" :wrap-around="true">
              <Slide v-for="facility in facilities" :key="facility.id">
                <div class="bg-white shadow-md rounded-lg p-4 w-full h-40 flex flex-col justify-between">
                  <h4 class="font-semibold">{{ facility.name }}</h4>
                  <p class="text-gray-700 flex-grow">{{ facility.description }}</p>
                  <router-link :to="{ name: 'FacilityAreas', params: { facilityId: facility.id } }" class="text-blue-500 hover:underline">View Areas</router-link>
                </div>
              </Slide>
              <template #addons>
                <Navigation />
                <Pagination />
              </template>
            </Carousel>
          </section>

          <!-- Areas Section -->
          <section class="mb-8 bg-gray-100 p-4 rounded-lg shadow-md">
            <h3 class="text-xl font-semibold mb-4 text-center">Areas</h3>
            <Carousel :items-to-show="3" :wrap-around="true">
              <Slide v-for="area in areas" :key="area.id">
                <div class="bg-white shadow-md rounded-lg p-4 w-full h-40 flex flex-col justify-between">
                  <h4 class="font-semibold">{{ area.name }}</h4>
                  <p class="text-gray-700 flex-grow">{{ area.description }}</p>
                  <p class="text-gray-700"><strong>Capacity:</strong> {{ area.capacity }}</p>
                  <router-link :to="{ name: 'AreaReservationDetailedView', params: { facilityId: area.facilityId, areaId: area.id } }" class="text-blue-500 hover:underline">Reserve Area</router-link>
                </div>
              </Slide>
              <template #addons>
                <Navigation />
                <Pagination />
              </template>
            </Carousel>
          </section>

          <!-- Events Section -->
          <section class="mb-8 bg-gray-100 p-4 rounded-lg shadow-md">
            <h3 class="text-xl font-semibold mb-4 text-center">Upcoming Events</h3>
            <Carousel :items-to-show="3" :wrap-around="true">
              <Slide v-for="event in events" :key="event.id">
                <div class="bg-white shadow-md rounded-lg p-4 w-full h-40 flex flex-col justify-between">
                  <h4 class="font-semibold">{{ event.name }}</h4>
                  <p class="text-gray-700 flex-grow">{{ event.description }}</p>
                  <p class="text-gray-700"><strong>Date:</strong> {{ new Date(event.startTime).toLocaleDateString() }}</p>
                  <p class="text-gray-700"><strong>Sold tickets:</strong> {{ event.currentAttendees }}</p>
                  <p class="text-gray-700"><strong>Max attendees:</strong> {{ event.maxAttendees }}</p>
                  <router-link :to="{ name: 'EventDetailedView', params: { eventId: event.id } }" class="text-blue-500 hover:underline">View Event</router-link>
                </div>
              </Slide>
              <template #addons>
                <Navigation />
                <Pagination />
              </template>
            </Carousel>
          </section>
        </div>
      </div>
    </main>
  </div>
</template>

<script setup>
import { onMounted } from 'vue';
import BaseNavbar from '../components/BaseNavbar.vue';
import { useAreas } from '../composables/useAreas';
import { useEvents } from '../composables/useEvents';
import { useFacilities } from '../composables/useFacilities';
import { Carousel, Slide, Navigation, Pagination } from 'vue3-carousel';
import 'vue3-carousel/dist/carousel.css';

const { areas, fetchAreas } = useAreas();
const { events, fetchEvents } = useEvents();
const { facilities, fetchFacilities } = useFacilities();

onMounted(() => {
  fetchAreas();
  fetchEvents();
  fetchFacilities();
});
</script>

<style scoped>
.carousel-slide {
  width: 100%;
  height: 100%;
}
</style>
